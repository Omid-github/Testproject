using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit;
using NUnit.Framework;




namespace Specflow
{
    public class Specflow

    {
        private readonly ScenarioContext _scenarioContext;
        public Specflow(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

    }
}
