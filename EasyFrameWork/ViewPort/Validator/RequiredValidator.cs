/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Easy.Extend;

namespace Easy.ViewPort.Validator
{
    public class RequiredValidator : ValidatorBase
    {
        public RequiredValidator()
        {
            this.BaseErrorMessage = "请输入{0}";
        }
        public override bool Validate(object value)
        {
            if (value == null || value.ToString().IsNullOrEmpty()) return false;
            else return true;
        }
    }
}
