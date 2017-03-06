using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Gpio;

namespace RPiQMR
{
    class Sensor
    {
        private int _SENSOR_PIN;
        private int _DELAY_TIME;
        private int _ROOMID;
        private int _SENSORID;
        private int _LED_PIN;
        private GpioPin _pin;
        private LED _led;
        QMRWebService _reserve;
        private GpioPinValue _val;
        private bool _isTriggered;

        //Constructor 
        public Sensor(int SensorPin, int DelayTime, int SensorId, int RoomId, int LedPin)
        {
            var gpio = GpioController.GetDefault();
            _SENSOR_PIN = SensorPin;
            _DELAY_TIME = DelayTime;
            _ROOMID = RoomId;
            _SENSORID = SensorId;
            _LED_PIN = LedPin;
            _pin = gpio.OpenPin(_SENSOR_PIN);
            _led = new LED(_LED_PIN);
            _reserve = new QMRWebService();
        }

        //Check to see if sensor port is giving out a reading
        public bool active()
        {
            return (_pin != null);
        }

        //Starts listening for changes in sensor
        public void Start()
        {
            _isTriggered = false;
            _led.Led_Off();
            _reserve.SetRoomStatus(_SENSORID, _ROOMID, false);


            _pin.DebounceTimeout = TimeSpan.FromSeconds(1); //EverySecond
            _pin.ValueChanged += OnValueChanged;

        }

        private void MovementSensed()
        {
            _val = _pin.Read();
            while (_val == GpioPinValue.High)
            {
                Task.Delay(_DELAY_TIME).Wait();
                _val = _pin.Read();
            }
            _led.Led_Off();
            _reserve.SetRoomStatus(_SENSORID, _ROOMID, false);
            _isTriggered = false;
        }

        //Handles LED light on movement{database writing}
        private void OnValueChanged(GpioPin sender, GpioPinValueChangedEventArgs args)
        {
            if (!_isTriggered)
            {
                if (args.Edge == GpioPinEdge.RisingEdge) //from off to on
                {
                    _isTriggered = true;
                    _led.Led_On();
                    _reserve.SetRoomStatus(_SENSORID, _ROOMID, true);
                    Task.Delay(_DELAY_TIME).Wait();
                    MovementSensed();
                }
                else //from on to off
                {
                    _led.Led_Off();
                    _reserve.SetRoomStatus(_SENSORID, _ROOMID, false);
                }
            }
        }
    }
}
