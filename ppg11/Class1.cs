using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppg11
{
   
    public class Train
    {
        public int CarriageCount { get; set; }
        public List<string> CarriageTypes { get; set; }
    }

   
    public abstract class TrainHandler
    {
        protected TrainHandler _nextHandler;

        public void SetNext(TrainHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract bool Handle(Train train, Control control);
    }

    
    public class CarriageCountHandler : TrainHandler
    {
        private readonly int _maxCarriageCount;

        public CarriageCountHandler(int maxCarriageCount)
        {
            _maxCarriageCount = maxCarriageCount;
        }

        public override bool Handle(Train train, Control control)
        {
            if (train.CarriageCount > _maxCarriageCount)
            {
                MessageBox.Show(control, $"Кількість вагонів поїзда перевищує максимальний ліміт ({_maxCarriageCount}).");
                return false;
            }

            if (_nextHandler != null)
            {
                return _nextHandler.Handle(train, control);
            }

            return true;
        }
    }

    
    public class CarriageTypeHandler : TrainHandler
    {
        private readonly List<string> _allowedCarriageTypes;

        public CarriageTypeHandler(List<string> allowedCarriageTypes)
        {
            _allowedCarriageTypes = allowedCarriageTypes;
        }

        public override bool Handle(Train train, Control control)
        {
            foreach (var carriageType in train.CarriageTypes)
            {
                if (!_allowedCarriageTypes.Contains(carriageType))
                {
                    MessageBox.Show(control, $"Поїзд містить недійсний тип вагона ({carriageType}).");
                    return false;
                }
            }

            if (_nextHandler != null)
            {
                return _nextHandler.Handle(train, control);
            }

            return true;
        }
    }
}
