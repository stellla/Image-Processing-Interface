using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Serialization;
using ProtoBuf;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace OperationsPool
{
    [ProtoContract]
    public class Operations 
    {
        [ProtoMember(1)]
        public string language; 
        [ProtoMember(2)]
        public string function_name;
        [ProtoMember(3)]
        public List<Parameters> parameters {get;set;}

        public string Language
        {
            get { return language; }
            set { language = value; }
        }
        public string Function_name
        {
            get { return function_name; }
            set { function_name = value; }
        }
            
        public Operations(string lan, string f_name)// constructor
        {
            language = lan;
            function_name = f_name;
            parameters = new List<Parameters>();
            
        }
        public Operations()
        {
            parameters = new List<Parameters>();
        }
     
    }

        [ProtoContract]
        public class Parameters 
        {   
            [ProtoMember(1)]
            public string name;
            [ProtoMember(2)]
            public string type; 
            [ProtoMember(3)]
            public string val;

            public string Name{
                get { return name; }
                set { name = value; }
           }

            public string Type
            {
                get { return type; }
                set { type = value; }
            }

            public string Val
            {
                get { return val; }
                set { val = value; }
            }
            //constructor
            public Parameters(string name, string type, string val)
            {
                this.name = name;
                this.type = type;
                this.val = val;
            }

            public Parameters()
            {

            }
        }

   

    }



