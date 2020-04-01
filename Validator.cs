﻿using System;
using System.Collections.Generic;
using System.Text;

namespace userRegistration
{
    interface Validator
    {
        string validateName(string firstName);
        string validateEmail(string email);
        string validateNumber(string number);
    }
}
