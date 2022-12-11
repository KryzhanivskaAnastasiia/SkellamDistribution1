using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkellamDistribution
{
    class CalculationGenerator
    {
        private ProcessData process;
        private int X0, X1;

        public CalculationGenerator(double a, double b, long total)
        {
            process = new ProcessData();
            process.setNewProcess(a, b, total, 0);
        }

        public CalculationGenerator(ProcessData process)
        {
            this.process = process;
        }

        public ProcessData getProcessData()
        {
            return process;
        }

        public void setProcessData(ProcessData process)
        {
            lock (this)
            {
                this.process = process;
            }
        }

        public void setNewData(double a, double b, long total)
        {
            if (!process.a.Equals(a) || !process.a.Equals(b))
            {
                this.process.setNewProcess(a, b, total, 0);
            }
            else
            {
                this.process.numberOfExperiments = total;
            }
        }

        public void generateRandomReverse()
        {
            lock (this)
            {
                double a = process.a;
                double b = process.b;
                int x = FortranLib.reverseFunc(ref a, ref b);
                if (process.reverseDictionary.ContainsKey(x))
                {
                    process.reverseDictionary[x] = process.reverseDictionary[x] + 1;
                }
                else
                {
                    process.reverseDictionary.Add(x, 1);
                }
            }
        }

        public void generateRandomNeyman()
        {
            lock (this)
            {
                double a = process.a;
                double b = process.b;
                int x = FortranLib.NeymanMethod(ref a, ref b);
                if (process.neumannDictionary.ContainsKey(x))
                {
                    process.neumannDictionary[x] = process.neumannDictionary[x] + 1;
                }
                else
                {
                    process.neumannDictionary.Add(x, 1);
                }
            }
        }

        public void generateRandomMetropolys()
        {
            lock (this)
            {
                double a = process.a;
                double b = process.b;
                FortranLib.MetropolysMethod(ref a, ref X0);
                FortranLib.MetropolysMethod(ref b, ref X1);
                int XD = X0 - X1;
                if (process.metropolisDictionary.ContainsKey(XD))
                {
                    process.metropolisDictionary[XD] = process.metropolisDictionary[XD] + 1;
                }
                else
                {
                    process.metropolisDictionary.Add(XD, 1);
                }
            }
        }

        public void makeSomeMetropolysSteps(int count)
        {
            double a = process.a;
            double b = process.b;

            X0 = (int)(b - a);
            X1 = (int)(b - a);
            for (int i = 0; i < count; i++)
            {
                lock (this)
                {
                    FortranLib.MetropolysMethod(ref a, ref X0);
                    FortranLib.MetropolysMethod(ref b, ref X1);
                }
            }
        }


        public void addExperiment()
        {
            process.addExperimentCount();
        }

        public void setCurrentNumberOfSteps(long reverse, long neumann, long metropolis)
        {
            lock (this)
            {
                process.currentStepsNumberReverse = reverse;
                process.currentStepsNumberNeumann = neumann;
                process.currentStepsNumberMetropolis = metropolis;

            }
        }
    }
}
