using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkellamDistribution
{
    [Serializable]
    public class ProcessData
    {
        private Dictionary<int, long> reverseMethod = new Dictionary<int, long>();
        private Dictionary<int, long> neumannMethod = new Dictionary<int, long>();
        private Dictionary<int, long> metropolisMethod = new Dictionary<int, long>();

        public Dictionary<int, long> reverseDictionary { get => reverseMethod; set => reverseMethod = value; }
        public Dictionary<int, long> neumannDictionary { get => neumannMethod; set => neumannMethod = value; }
        public Dictionary<int, long> metropolisDictionary { get => metropolisMethod; set => metropolisMethod = value; }

        public long currentStepsNumberReverse { get; set; }
        public long currentStepsNumberNeumann { get; set; }
        public long currentStepsNumberMetropolis { get; set; }

        public double percentStepCountReverse { get; set; }
        public double percentStepCountNeumann { get; set; }
        public double percentStepCountMetropolis { get; set; }
        public int percentReverse { get; set; }
        public int percentNeumann { get; set; }
        public int percentMetropolis { get; set; }
        public long numberOfExperiments { get; set; }
        public double a { get; set; }
        public double b { get; set; }
        public double currentExperimentCount { get; set; }


        public void setNewProcess(double a, double b, long total, double current)
        {
            this.a = a;
            this.b = b;
            this.numberOfExperiments = total;
            this.currentStepsNumberReverse = 0;
            this.currentStepsNumberNeumann = 0;
            this.currentStepsNumberMetropolis = 0;
            this.currentExperimentCount = current;
        }

        public void addExperimentCount()
        {
            this.currentExperimentCount++;
        }
    }
}
