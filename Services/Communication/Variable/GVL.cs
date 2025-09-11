using App_UI_Mobile_Laminado.Services.Authentication.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MAUI_Opcua.Services.Communication.Variable
{
    public partial class GVL
    {
        public class ConfSuper
        {
            public static class sUrlOpcUa
            {
                private static readonly object _lock = new object();
                private static string? _readValue;
                private static string? _writeValue;
                public static string? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
              
            }
            public static class iTimeOutPing
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
             
            }
            public static class iTimeRequest
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
             
            }
            public static class iMaxAgeOpcUa
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
             
            }
            public static class iMedAgeOpcUa
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
              
            }
            public static class iMinAgeOpcUa
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
               
            }
            public static class iZeroAgeOpcUa
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
               
            }
            public static class iQueryTime
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class sStatusOpcUa
            {
                private static readonly object _lock = new object();
                private static string? _readValue;
                private static string? _writeValue;
                public static string? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class iMaxTempRecipe
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class iMinTempRecipe
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class iMaxTempOperation
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class iMinTempOperation
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }
            public static class iContagemErro
            {
                private static readonly object _lock = new object();
                private static int? _readValue;
                private static int? _writeValue;
                public static int? ReadWrite
                {
                    get
                    {
                        lock (_lock)
                        {
                            return _readValue;
                        }
                    }
                    set
                    {
                        lock (_lock)
                        {
                            _readValue = value;
                        }
                    }
                }
            }

        }
       
        

        public class Opcua
        {
            public class Test
            {
                public static class xC1_DI0
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI1
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI2
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI3
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI4
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI5
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI6
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI7
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI8
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI9
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI10
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI11
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI12
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI13
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI14
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DI15
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }



                public static class xC1_DQ0
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ1
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ2
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ3
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ4
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ5
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ6
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC1_DQ7
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class xC2_DQ0
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ1
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ2
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ3
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ4
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ5
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ6
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xC2_DQ7
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }






                public static class iTest
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class rTest
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class sTest
                {
                    private static readonly object _lock = new object();
                    private static string? _readValue;
                    private static string? _writeValue;
                    public static string? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static string? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iCount
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
            }

            public class EntradasSaidas
            {
                public static class ImgTesteEntLog
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[24];
                    private static readonly bool?[] _writeValues = new bool?[24];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }

                public static class ImgForceSaiLog
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[16];
                    private static readonly bool?[] _writeValues = new bool?[16];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }

            }

            public class GVL_Ihm_Manual
            {
                public static class xBtAbreFechaDampSup
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtAbreFechaPortaSup
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaBomVac01
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaVentSup
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaSsrS01
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaSsrS02
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaSsrS03
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtLigaDesligaSsrS04
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }





            }
            
            public class GVL_ImagensAlarmes
            {
                static int SupNum = 7;
                static int InfNum = 4;
                public static class ImgGeral
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[21];
                    private static readonly bool?[] _writeValues = new bool?[21];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class ImgMotor
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[11];
                    private static readonly bool?[] _writeValues = new bool?[11];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class ImgRetornoSsrInferior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[InfNum];
                    private static readonly bool?[] _writeValues = new bool?[InfNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class ImgRetornoSsrSuperior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class AlmTemperaturaExcedeuInferior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[InfNum];
                    private static readonly bool?[] _writeValues = new bool?[InfNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class AlmTemperaturaExcedeuSuperior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class AlmTermoparAbertoInferior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[InfNum];
                    private static readonly bool?[] _writeValues = new bool?[InfNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class AlmTermoparAbertoSuperior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeResistRompidaInferior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[InfNum];
                    private static readonly bool?[] _writeValues = new bool?[InfNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeResistRompidaSuperior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeSsrInferiorAberto
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeSsrSuperiorAberto
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeSsrInferiorFechado
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
                public static class xAlarmeSsrSuperiorFechado
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[SupNum];
                    private static readonly bool?[] _writeValues = new bool?[SupNum];

                    public static bool? GetRead(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            return _readValues[index];
                        }
                    }

                    public static void SetRead(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _readValues.Length)
                                throw new IndexOutOfRangeException("Índice de leitura fora do intervalo.");

                            _readValues[index] = value;
                        }
                    }

                    public static bool? GetWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            return _writeValues[index];
                        }
                    }

                    public static void SetWrite(int index, bool? value)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de escrita fora do intervalo.");

                            _writeValues[index] = value;
                        }
                    }
                    public static void ClearWrite(int index)
                    {
                        lock (_lock)
                        {
                            if (index < 0 || index >= _writeValues.Length)
                                throw new IndexOutOfRangeException("Índice de limpeza fora do intervalo.");

                            _writeValues[index] = null;
                        }
                    }
                }
            }

            public class GVL_Energia
            {
                public static class fCorrenteFaseA
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteFaseB
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteFaseC
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteNeutro
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class fCorrenteMaximaFaseA
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteMaximaFaseB
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteMaximaFaseC
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteMaximaNeutro
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }


                public static class fTensaoAN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoBN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoCN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class fTensaoAB
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoBC
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoCA
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class fTensaoMaximaAN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoMaximaBN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoMaximaCN
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class fTensaoMaximaAB
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoMaximaBC
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fTensaoMaximaCA
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class fTensaoAvgLL
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fCorrenteAvg
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fPotenciaAtivaTotal
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fEnergiaAtivaAcumulada
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fAtualDemanda
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fPicoDemanda
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fFatorPotenciaTotal
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class fFrequencia
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }


            }

            public class GVL_ClpIhm
            {
                public static class xOperacaoAutomatico
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xAlarme
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPortaEsq
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xVacuo01Ok
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rFrequenciaAtualVentSup
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iTermoparSup01
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorRampa08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorRampa08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iSegDecorRampa01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorRampa08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iHorDecorPatam01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorDecorPatam08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinDecorPatam01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorPatam08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iSegDecorPatam01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorPatam08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class uStatusAquecimentoSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class wStatusRampa01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusRampa08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class wStatusPatamar01Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar02Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar03Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar04Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar05Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar06Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar07Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class wStatusPatamar08Sup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinDecorTasbSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorTasbSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinDecorResfrSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorResfrSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinDecorAbPortSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorAbPortSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iHorDecorTotalSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinDecorTotalSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSegDecorTotalSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorProgTotalSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinProgTotalSup
                {
                    private static readonly object _lock = new object();
                    private static int? _readValue;
                    private static int? _writeValue;
                    public static int? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static int? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xCicloLaminaSupHabilitado
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xAlarmeHorimetroB01
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xAlarmeHorimetroB02
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xEmergencia
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xFimCurso
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xTermostatoOn
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
            }

            public class GVL_Permanentes
            {
                public static class iMinCxSupRampa01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa02
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa03
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa04
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa05
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa06
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa07
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupRampa08
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iTempoExaustorMinSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iTempoAberturaSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTemperaturaMinimaSup
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class uLdomingo
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLsegunda
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLterca
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLquarta
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLquinta
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLsexta
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uLsabado
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uHorProgramado
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iFreqManCxSuperior
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class uMinProgramado
                {
                    private static readonly object _lock = new object();
                    private static uint? _readValue;
                    private static uint? _writeValue;
                    public static uint? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static uint? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iSpContHorProgB01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iTemperaturaSegurancaSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }











            }

            public class GVL_IhmClp
            {
                public static class xBtRstAlm
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rTempCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iHorCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iHorCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iMinCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class iMinTasbCxSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

                public static class BtLdVacuoMesa01
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xBtIniciaCicloSup
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class xAbortaCicloSup
                {
                    private static readonly object _lock = new object();
                    private static bool? _readValue;
                    private static bool? _writeValue;
                    public static bool? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static bool? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }




            }

            public class GVL_Receita
            {
                public static class iRecMinCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecHorCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar01
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar02
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar03
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar04
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar05
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar06
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar07
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class rRecTempCxSupPatamar08
                {
                    private static readonly object _lock = new object();
                    private static float? _readValue;
                    private static float? _writeValue;
                    public static float? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static float? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp01Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp02Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp03Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp04Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp05Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp06Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp07Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecSp08Vacuo01
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iRecMinTasbCxSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }
                public static class iEscreveReceitaCxSup
                {
                    private static readonly object _lock = new object();
                    private static Int16? _readValue;
                    private static Int16? _writeValue;
                    public static Int16? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static Int16? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }

            }

        }



        public class Authentication
        {
            public static class SessaoUsuario
            {

                public static class sUsuario
                {
                    private static readonly object _lock = new object();
                    private static string? _readValue;
                    private static string? _writeValue;
                    public static string? Read
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _readValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _readValue = value;
                            }
                        }
                    }
                    public static string? Write
                    {
                        get
                        {
                            lock (_lock)
                            {
                                return _writeValue;
                            }
                        }
                        set
                        {
                            lock (_lock)
                            {
                                _writeValue = value;
                            }
                        }
                    }
                }


                /*
                private static ReaderWriterLockSlim _rwLock = new();
                private static Usuario _UsuarioAtual;

                public static Usuario UsuarioAtual
                {
                    get
                    {
                        _rwLock.EnterReadLock();
                        try { return _UsuarioAtual; }
                        finally { _rwLock.ExitReadLock(); }
                    }
                    set
                    {
                        _rwLock.EnterWriteLock();
                        try { _UsuarioAtual = value; }
                        finally { _rwLock.ExitWriteLock(); }
                    }
                }




                public static void Login(Usuario usuario)
                {
                    UsuarioAtual = usuario;
                }

                public static void Logout()
                {
                    UsuarioAtual = null;
                }

                public static bool EstaLogado => UsuarioAtual != null;
                */
            }
        }
    }
}
