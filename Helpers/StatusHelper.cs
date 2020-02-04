using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SeleniumProject.Helpers

{

    public class StatusHelper

    {

        public static Status ConvertBoolToPassOrFailStatus(bool value)

        {

            return value ? Status.Pass : Status.Fail;

        }

        public static bool ConvertPassOrFailStatusToBool(Status value)

        {

            return value == Status.Pass;

        }



        public static Status OppositeStatus(Status status)

        {

            return status == Status.Fail ? Status.Pass : Status.Fail;

        }

    }

}

