using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Serialization;
using ProtoBuf;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using OperationsPool;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Collections;


namespace OperationPool
{

    public partial class Form1 : Form
    {
        //***********************************declarations of variables****************************************8
        List<Operations> OperationsList = new List<Operations>();// list of objects    
        List<string> OPlistParam = new List<string>();
        string line = "";
        List<Operations> BackOpList = new List<Operations>();
        string functionString = "";



        Operations FindOP;
        List<Operations> FindOPList = new List<Operations>();
        List<Parameters> FindParamsList = new List<Parameters>();


        // file path for srialization:
        static String path = @"C:\Users\StellaMel\Documents\Visual Studio 2013\Projects\operationsPool1\OperationPool\bin\Debug\protobuf\Operation.proto.bin";
        List<string> paths = new List<string>();
        FileStream f;
        String fName = "";
        String newPath = "";
        String DirectoryPath = @"C:\Users\StellaMel\Documents\Visual Studio 2013\Projects\operationsPool1\OperationPool\bin\Debug\protobuf";
        Boolean AddFunctionClicked;

        //************************************************************************************************************************

        public Form1()
        {
            InitializeComponent();
            parameters_window.Visible = false;
        }

        /// <summary>
        /// the method deserializes all operations from a chosen file and shows them in the operation list window
        /// </summary>
        public void deserializeByChosenFile()
        {
            FileStream chosenFile;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            List<Operations> backFile;
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    // take the file path
                    string text = File.ReadAllText(file);

                    using (chosenFile = new FileStream(file, FileMode.Open))
                    {
                        backFile = new List<Operations>();
                        Operations Op = null;
                        //deserialize file content
                        while ((Op = Serializer.DeserializeWithLengthPrefix<Operations>(chosenFile, PrefixStyle.Base128, 1)) != null)
                        {
                            //add deserialized operation to list
                            backFile.Add(Op);
                        }
                    }

                    chosenFile.Close();

                    // pull file name from path
                    int from = file.LastIndexOf(".");
                    string fileName = file.Substring(from);
                    //Debug.WriteLine(fileName);

                    ShowDataInTextBox(fileName, backFile);
                    //PrintDataToConsole(backFile);
                    // Debug.WriteLine(file);
                }
                catch (IOException)
                {
                    MessageBox.Show("An erro accured whie opening file " + file);
                }
            }

        }


        /// <summary>
        ///method: shows all sets of operations in operation list window (not in use)
        /// </summary>
        public void deserializaAllFiles()
        {
            //get path for folder 
            String DirectoryPath = @"C:\Users\StellaMel\Documents\Visual Studio 2013\Projects\OperationPool\OperationPool\bin\Debug\protobuf";
            int counter = 1;
            List<Operations> back = null;
            //  for each file in the folder get path 
            foreach (var path in Directory.GetFiles(DirectoryPath))
            {

                paths.Add(path);
                // foreach (string p in paths)
                // Debug.WriteLine(p);
                //deserialize 
                using (f = new FileStream(path, FileMode.Open))
                {
                    back = new List<Operations>();
                    Operations BackOp = null;
                    while ((BackOp = Serializer.DeserializeWithLengthPrefix<Operations>(f, PrefixStyle.Base128, 1)) != null)
                    {
                        back.Add(BackOp);
                    }
                }
                //ShowDataInTextBox(counter, "Set", back);
                counter++;
            }
            // PrintDataToConsole(back);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="set"></param>
        /// <param name="back"></param>
        public void ShowDataInTextBox(string set, List<Operations> back)
        {

            functionString += "\r\n" + "Set Loaded :" + set + "\r\n";
            foreach (Operations op in back)
            {
                functionString += op.language + " " + op.function_name + "(";
                foreach (Parameters par in op.parameters)
                {
                    functionString += par.name + " " + par.type + " " + par.val + ", ";
                }
                functionString += ") \r\n";

            }
            textBox1.Text += functionString;
            functionString += "\r\n\r\n";
            functionString = "";

        }


        /// <summary>
        ///load button: on click:deserializes all data in file and prints to console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            deserializeByChosenFile();
            //deserializaAllFiles();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Operations> DeserializeData()
        {
            List<Operations> oper = new List<Operations>();
            fName = fileName.Text;
            newPath = path + fName;
            using (f = new FileStream(newPath, FileMode.Open))
            {
                Operations BackOp = null;
                while ((BackOp = Serializer.DeserializeWithLengthPrefix<Operations>(f, PrefixStyle.Base128, 1)) != null)
                {
                    oper.Add(BackOp);
                }
            }
            return oper;
        }

        /// <summary>
        ///print deserialized data to console
        /// </summary>
        /// <param name="Mylist"></param>
        public void PrintDataToConsole(List<Operations> Mylist)
        {
            foreach (Operations BackOp in Mylist)
            {
                Debug.WriteLine("language: " + BackOp.Language + ", function name: " + BackOp.Function_name);

                foreach (Parameters p in BackOp.parameters)
                {
                    Debug.WriteLine("Parameter: " + p.name + " " + p.type + " " + p.val);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            disableFields();
        }

        public void disableFields()
        {
            Pname.Enabled = false;
            Ptype.Enabled = false;
            Pvalue.Enabled = false;
            parameters_window.Visible = false;
            AddParametersBtn.Enabled = true;
            serialize.Enabled = false;
            AddParametersBtn.Enabled = true;
        }

        /// <summary>
        ///on click: adds function to a list. list of functions to save
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFunctionBtn_Click(object sender, EventArgs e)
        {
            function_name.Enabled = true;
            AddFunctionBtn.Enabled = true;
            AddParametersBtn.Enabled = true;
            serialize.Enabled = true;
            Button clickedButton = (Button)sender;
            AddFunctionClicked = true;
            FindOP = new Operations(lan.SelectedItem.ToString(), function_name.Text);
        }


        /// <summary>
        ///on click: enables the fields to input parameters to existing function 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddParametersBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Pname.Enabled = true;
            Ptype.Enabled = true;
            Pvalue.Enabled = true;
            parameters_window.Visible = true;
        }

        /// <summary>
        ///on click: saves using serialization thr function list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void serialize_Click(object sender, EventArgs e)
        {
            //String fName = "";
            fName = fileName.Text;
            newPath = path + fName;
            f = File.Create(newPath);
            f.Close();
            int set = 1;

            using (f = new FileStream(newPath, FileMode.Open))
            {
                textBox1.Text += "\n\r\n\r Set to save number" + set + "\n\r";
                textBox1.Text += "\n\r\n\r\n";

                foreach (Operations op in FindOPList)
                {
                    Serializer.SerializeWithLengthPrefix(f, op, PrefixStyle.Base128, 1);
                }
                //f.Close();
            }
            set++;
            Debug.WriteLine("current set " + set);
            cleanOpList(FindOPList);
            FindOPList.Clear();
            f.Close();
        }

        /// <summary>
        ///on cick: add new parameter to function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addP_btn_Click(object sender, EventArgs e)
        {
            AddParamsToOP();
        }

        /// <summary>
        ///on click: show added function in window lisBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToListBtn_Click(object sender, EventArgs e)
        {
            line = "";
            Button clickedButton = (Button)sender;
            if (AddFunctionClicked == true)
            {
                textBox1.Text += "\r\n";
                line += lan.SelectedItem.ToString() + "," + function_name.Text + " (";// +Pname.Text + Ptype.Text + Pvalue.Text;
                // line += Pname.Text + " " + Ptype.Text + " " + Pvalue.Text + " ";
                line += Ptype.Text + " " + Pvalue.Text;
                lan.Text = "";
                /// lang.Text = "";
                function_name.Text = "";
                Pname.Text = "";
                Ptype.Text = "";
                Pvalue.Text = "";
                AddFunctionClicked = false;
            }
            else
            {
                line += "," + Pname.Text + " " + Ptype.Text + " " + Pvalue.Text + " ";
                Pname.Text = "";
                Ptype.Text = "";
                Pvalue.Text = "";
            }

            textBox1.Text += line;
            line = "";
            AddFunctionClicked = false;

        }

        /// <summary>
        ///closes the application. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///done adding parameters to function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void DoneBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            line += " )";
            textBox1.Text += line;
            FindOPList.Add(FindOP);
            parameters_window.Visible = false;

        }




        /// <summary>
        ///finds function in data: if found "calculates" it if not found serializes it 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>     
        private void DoItBtn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Debug.WriteLine("list of op to find:");
            PrintDataToConsole(FindOPList);
            findObjectsInPath(paths);

        }

        /// <summary>
        ///add new parameter to function
        /// </summary>
        public void AddParamsToOP()
        {
            Parameters NewParams = new Parameters(Pname.Text, Ptype.Text, Pvalue.Text);
            FindOP.parameters.Add(NewParams);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="BackOpList"></param>
        /// <param name="FindOPList"></param>
        /// <returns></returns>
        public Boolean Comparisson(List<Operations> BackOpList, List<Operations> FindOPList)
        {
            Boolean found = false;
            if (FindOPList.Count == BackOpList.Count)
            {
                found = ComparerEqualCount(BackOpList, FindOPList);
                if (found == true)
                    return true;
                else return false;
            }
            return false;
        }



        /// <summary>
        /// converts list of kind Operations to hashSet
        /// </summary>
        /// <param name="ListToConvert"></param>
        /// <returns></returns>
        public HashSet<Operations>  ConvertListToHashSet(List<Operations> ListToConvert)
        {
            HashSet<Operations> Set = new HashSet<Operations>();

            foreach (Operations op in ListToConvert)
            {
                Set.Add(op);
            }
            return Set;
        }
        /// <summary>
        ///mthod: gets two lists of functions set and returns result if they are equal or not.
        /// BackOpList contains operations pulled from saved data
        ///FindOpList contains set of operations to find. 
        ///this method compares only equal count lists.
        ///input: BackOpList ,FindOpList
        /// output: true if lists match, false otherwise
        /// </summary>
        /// <param name="BackOpList"></param>
        /// <param name="FindOPList"></param>
        /// <returns></returns>
        public Boolean ComparerEqualCount(List<Operations> BackOpList, List<Operations> FindOPList)
        {

            //convert from list to hash set
            HashSet<Operations> backSet = new HashSet<Operations>();
            backSet = ConvertListToHashSet(BackOpList);
            HashSet<Operations> findSet = new HashSet<Operations>();
            findSet = ConvertListToHashSet(FindOPList);

            //foreach (Operations op in BackOpList)
            //{
            //    backList.Add(op);
            //}


            //foreach (Operations op in FindOPList)
            //{
            //    findList.Add(op);
            //}



            int i;
            int k;
            // boolean array, will contain true or false for each operation overview in backList against findList
            Boolean[] opFound = new Boolean[backSet.Count];

            //main loop, goes over the hashSets: findList ,backList
            for (i = 0; i < findSet.Count; i++)
            {
                //case: attributes name or language dont match
                if (!findSet.ElementAt(i).language.Equals(backSet.ElementAt(i).language) || !findSet.ElementAt(i).function_name.Equals(backSet.ElementAt(i).function_name))
                    opFound[i] = false;

                // name and language attributes match
                if (findSet.ElementAt(i).language.Equals(backSet.ElementAt(i).language) && findSet.ElementAt(i).language.Equals(backSet.ElementAt(i).language))
                {
                    // if lists sizes of parameters match on both operations
                    if (findSet.ElementAt(i).parameters.Count == backSet.ElementAt(i).parameters.Count)
                    {
                        // boolean array for parameters. will contain true or false for each param overview
                        Boolean[] Pfound = new Boolean[findSet.ElementAt(i).parameters.Count];
                        //run through the params lists
                        for (k = 0; k < findSet.ElementAt(i).parameters.Count; k++)
                        {
                            if (findSet.ElementAt(i).parameters.ElementAt(k).name.Equals(backSet.ElementAt(i).parameters.ElementAt(k).name) &&
                                findSet.ElementAt(i).parameters.ElementAt(k).type.Equals(backSet.ElementAt(i).parameters.ElementAt(k).type) &&
                                findSet.ElementAt(i).parameters.ElementAt(k).val.Equals(backSet.ElementAt(i).parameters.ElementAt(k).val)
                                )
                                // all attributes match--> the param is a match
                                Pfound[k] = true;

                            else // one or more attributes does not match
                                Pfound[k] = false;
                        }
                        /// check params array : if all cells are true the op matches else the op doesnt match
                        for (int p = 0; p < Pfound.Length; p++)
                        {
                            if (Pfound[p] == false)
                            {
                                // op not equals
                                opFound[i] = false;
                                break;
                            }
                            // op equals
                            else opFound[i] = true;
                        }
                    }
                    // operations parms list size different
                    if (findSet.ElementAt(i).parameters.Count != backSet.ElementAt(i).parameters.Count)
                    {
                        for (k = 0; k < findSet.ElementAt(i).parameters.Count; k++)
                        {
                            opFound[i] = false;
                        }
                    }
                }
            }
            Boolean find = checkFound(opFound);
            if (find == true)
                return true;
            else
                return false;


        }


        /// <summary>
        /// check the boolean array of operations. if all cells are true - set of operations is a match
        /// </summary>
        /// <param name="opFound"></param>
        /// <returns></returns>
        public Boolean checkFound(Boolean[] opFound)
        {
            for (int i = 0; i < opFound.Length; i++)
            {
                if (opFound[i] == false)
                    continue;
                else if (opFound[i] == true)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// gets all data from files. for each file deserialises and calls Comparisson method to find (or not)
        /// a match
        /// </summary>
        /// <param name="paths"></param> list of all paths of saved files
        public void findObjectsInPath(List<string> paths)
        {

            List<Operations> BackOpList = new List<Operations>();
            // for each file in the folder get path 
            foreach (var path in Directory.GetFiles(DirectoryPath))
                paths.Add(path);
            //foreach (string p in paths)
            //Debug.WriteLine(p);
            int counter = 0;
            foreach (string pat in paths)
            {
                //1.deserialize

                using (f = new FileStream(pat, FileMode.Open))
                {
                    Operations BackOp = null;
                    while ((BackOp = Serializer.DeserializeWithLengthPrefix<Operations>(f, PrefixStyle.Base128, 1)) != null)
                    {
                        BackOpList.Add(BackOp);// list of deserialized operations      
                        //Comparisson(BackOpList, FindOPList);
                    }

                }
                counter++;
                Boolean find = Comparisson(BackOpList, FindOPList);
                if (find == false)
                {
                    cleanOpList(BackOpList);
                    BackOpList.Clear();
                    // if the last round:
                    if (counter == paths.Count)
                    {
                        // Debug.WriteLine("Debug1");
                        MessageBox.Show("Set was NOT found , Saving  new set");
                    }
                    continue;

                }
                if (find == true)
                {
                    cleanOpList(FindOPList);
                    FindOPList.Clear();
                    MessageBox.Show("Set already exists ,processing...");
                    break;
                }

            }
        //    PrintDataToConsole(FindOPList);
        }

        public void cleanOpList(List<Operations> FindOPList)
        {
            foreach (Operations op in FindOPList)
            {
                op.parameters.Clear();
            }
        }



    }
}

