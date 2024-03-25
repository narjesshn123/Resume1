using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application;        
    public class OperationResult
    {
    public OperationResult Success(string message=("عملیات با موفقیت انجام شد. "))
    {
        IsSuccess = true; 
        Message = message;
        return this; 
    }
    public OperationResult Failed(string message)
    {
        IsSuccess = false; 
        Message = message;
        return this;
    }
    public bool IsSuccess { get; set; }
    public string Message { get; set; } 
    }

