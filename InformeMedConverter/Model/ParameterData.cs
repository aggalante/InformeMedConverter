#region Copyright © 2014, Critical Health

// ===============================================================================
//   Copyright © 2014, Critical Health. All rights reserved                     //
//   http://www.critical-health.com/                                            //
// ===============================================================================

#endregion

namespace InformeMedConverter.Model
{
    public class ParameterData
    {
        public ParameterData(ParameterType type, string parameter, string result, string unit)
        {
            Type = type;
            Parameter = parameter;
            Result = result;
            Unit = unit;
        }

        public ParameterType Type { get; }

        public string Parameter { get; }

        public string Result { get; }

        public string Unit { get; }
    }
}
