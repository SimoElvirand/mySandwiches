using System;
using System.Globalization;
using Python.Runtime;
using System.Diagnostics;
using testPY;

namespace testPyC_
{
    internal class Program
    {
        static void Runscript()
        {
            //tell where is your python.dll
            Runtime.PythonDLL = @"C:\Users\simog\AppData\Local\Programs\Python\Python312\python312.dll";

            dynamic os = Py.Import("os");
            dynamic sys = Py.Import("sys");
            sys.path.append(os.getcwd());

            //initialization of the pythonengine
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                dynamic pythonScript = Py.Import("testPY");
                //j'appelle une methode which is in the python file
                dynamic result = pythonScript.InvokeMethod("say_hello");
                //passage de paramètre
                dynamic message = new PyString("message from Nick.");
                dynamic result1 = pythonScript.InvokeMethod("test", new PyObject[] {message});

            }
        }


        static void Runmod()
        {
            //tell where is your python.dll
            Runtime.PythonDLL = @"C:\Users\simog\AppData\Local\Programs\Python\Python312\python312.dll";
            //initialization of the pythonengine
            PythonEngine.Initialize();
            using (Py.GIL())
            {
                dynamic pythonScript = Py.Import("testPY");

                //Chargement du modèle depuis le module Python

                dynamic result0 = pythonScript.joblib.load("modele_regression.pkl");
                double[] features = new double[] { 2.3, 4.5, 6.7 };
                dynamic result = result0.predict(features);
                Console.WriteLine("Résultat de la prédiction : " + result);

            }
            PythonEngine.Shutdown();
        }
        static void Main(string[] args)
        {
            string rien = @"C:\Users\simog\AppData\Local\Programs\Python\Python312\python.exe";
            string output = "";
            string filepath = @"C:\Users\simog\Downloads\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\NASA-Turbofan-Jet-Engine-RUL-prediction-C-MAPSS-main\Failure prediction\testpy.txt";
            Console.WriteLine("Hello World!");
            //Runmod();
            //Runscript();

             Process ML = new Process();
            ML.StartInfo = new ProcessStartInfo("python.exe") {Arguments = "Untitled.py", RedirectStandardOutput = true};
            ML.Start();
            output = ML.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
            ML.WaitForExit();
            //process.StartInfo = new ProcessStartInfo(rien)
            //{
               // Arguments = "testPY.py",
                //RedirectStandardOutput = true,
            //};

            
        }
    } 
}
