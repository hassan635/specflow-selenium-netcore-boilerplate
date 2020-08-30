using System;
using System.Collections.Generic;

namespace specflow_selenium_netcore_boilerplate.src.lib.helpers
{
    public class TestSetting
    {
        public string Key { get; }
        public string Value { get; }
    }

    public class TestSettings
    {
        public List<TestSetting> TestSettingsCollection { get; }
    }
}
