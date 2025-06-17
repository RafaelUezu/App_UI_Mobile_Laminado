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
        public class ExitProgram
        {
            private static object lockObjectFor_xContinueRunning = new object();
            private static bool? _xContinueRunning;
            public static bool? xContinueRunning
            {
                get
                {
                    lock (lockObjectFor_xContinueRunning)
                    {
                        return _xContinueRunning;
                    }
                }
                set
                {
                    lock (lockObjectFor_xContinueRunning)
                    {
                        _xContinueRunning = value;
                    }
                }
            }
        }
        public class StatusCamera
        {
            private static object lockObjectFor_xTesteIniciaRelatorioCameraEntrada = new object();
            private static bool? _xTesteIniciaRelatorioCameraEntrada;
            public static bool? xTesteIniciaRelatorioCameraEntrada
            {
                get
                {
                    lock (lockObjectFor_xTesteIniciaRelatorioCameraEntrada)
                    {
                        return _xTesteIniciaRelatorioCameraEntrada;
                    }
                }
                set
                {
                    lock (lockObjectFor_xTesteIniciaRelatorioCameraEntrada)
                    {
                        _xTesteIniciaRelatorioCameraEntrada = value;
                    }
                }
            }
            private static object lockObjectFor_xStatusCamera = new object();
            private static bool? _xStatusCamera;
            public static bool? xStatusCamera
            {
                get
                {
                    lock (lockObjectFor_xStatusCamera)
                    {
                        return _xStatusCamera;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusCamera)
                    {
                        _xStatusCamera = value;
                    }
                }
            }
            private static object lockObjectFor_sTempoRegistroCamera = new object();
            private static string? _sTempoRegistroCamera;
            public static string? sTempoRegistroCamera
            {
                get
                {
                    lock (lockObjectFor_sTempoRegistroCamera)
                    {
                        return _sTempoRegistroCamera;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoRegistroCamera)
                    {
                        _sTempoRegistroCamera = value;
                    }
                }
            }
            private static object lockObjectFor_sIdUltimaCarga = new object();
            private static string? _sIdUltimaCarga;
            public static string? sIdUltimaCarga
            {
                get
                {
                    lock (lockObjectFor_sIdUltimaCarga)
                    {
                        return _sIdUltimaCarga;
                    }
                }
                set
                {
                    lock (lockObjectFor_sIdUltimaCarga)
                    {
                        _sIdUltimaCarga = value;
                    }
                }
            }
        }
        public class Tempo
        {
            private static object lockObjectFor_sDataCompleta = new object();
            private static string? _sDataCompleta;
            public static string? sDataCompleta
            {
                get
                {
                    lock (lockObjectFor_sDataCompleta)
                    {
                        return _sDataCompleta;
                    }
                }
                set
                {
                    lock (lockObjectFor_sDataCompleta)
                    {
                        _sDataCompleta = value;
                    }
                }
            }
        }

        public class StatusOpcua
        {
            private static object lockObjectFor_xStatusIp = new object();
            private static bool? _xStatusIp;
            public static bool? xStatusIp
            {
                get
                {
                    lock (lockObjectFor_xStatusIp)
                    {
                        return _xStatusIp;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusIp)
                    {
                        _xStatusIp = value;
                    }
                }
            }
            private static object lockObjectFor_xStatusOpcua = new object();
            private static bool? _xStatusOpcua;
            public static bool? xStatusOpcua
            {
                get
                {
                    lock (lockObjectFor_xStatusOpcua)
                    {
                        return _xStatusOpcua;
                    }
                }
                set
                {
                    lock (lockObjectFor_xStatusOpcua)
                    {
                        _xStatusOpcua = value;
                    }
                }
            }
            private static object lockObjectFor_sTempoCheckIp = new object();
            private static string? _sTempoCheckIp;
            public static string? sTempoCheckIp
            {
                get
                {
                    lock (lockObjectFor_sTempoCheckIp)
                    {
                        return _sTempoCheckIp;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoCheckIp)
                    {
                        _sTempoCheckIp = value;
                    }
                }
            }

            private static object lockObjectFor_sTempoRequesicaoOpcua = new object();
            private static string? _sTempoRequesicaoOpcua;
            public static string? sTempoRequesicaoOpcua
            {
                get
                {
                    lock (lockObjectFor_sTempoRequesicaoOpcua)
                    {
                        return _sTempoRequesicaoOpcua;
                    }
                }
                set
                {
                    lock (lockObjectFor_sTempoRequesicaoOpcua)
                    {
                        _sTempoRequesicaoOpcua = value;
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
                public static class ImgRetornoSsrSuperior
                {
                    private static readonly object _lock = new object();
                    private static readonly bool?[] _readValues = new bool?[5];
                    private static readonly bool?[] _writeValues = new bool?[5];

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








            }





        }



        public class Authentication
        {
            public static class SessaoUsuario
            {
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
