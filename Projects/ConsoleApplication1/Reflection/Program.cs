using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        private static int a = 5, b = 10, c = 20;

        static void Main(string[] args)
        {
            const string test = "test";
            Console.WriteLine(test.GetType().FullName);
            Console.WriteLine(typeof (Int32).FullName);
            
            var assembly = Assembly.GetExecutingAssembly();
            var assemblyTypes = assembly.GetTypes();
            foreach (var type in assemblyTypes)
            {
                Console.WriteLine(type.Name);
            }

            Console.WriteLine("--------------------");

            var testType = typeof (DummyClass);
            var ctor = testType.GetConstructor(Type.EmptyTypes);
            if (ctor != null)
            {
                var instance = ctor.Invoke(null);
                var methodInfo = testType.GetMethod("TestMethod");
                Console.WriteLine(methodInfo.Invoke(instance, new object[] { 10 }));
            }

            Console.WriteLine("---------------------");

            Console.WriteLine("a + b + c = " + (a + b + c));
            Console.WriteLine("Please enter the name of the variable that you wish to change:");
            var varName = Console.ReadLine();
            var t = typeof (Program);
            var fieldInfo = t.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            if (fieldInfo != null)
            {
                Console.WriteLine("The current value of " + fieldInfo.Name + " is " + fieldInfo.GetValue(null) + ". You may enter a new value now:");
                var newValue = Console.ReadLine();
                int newInt;
                if (int.TryParse(newValue, out newInt))
                {
                    fieldInfo.SetValue(null, newInt);
                    Console.WriteLine("a + b + c = " +(a + b + c));
                }
            }

            Console.WriteLine("------------------------");

            var person = new Person();
            person.Load();
            if ((person.Age > 0) && (person.Name != String.Empty))
            {
                Console.WriteLine("Hi " + person.Name + " - you are " + person.Age + " years old.");
            }
            else
            {
                Console.WriteLine("I don't seem to know much about you. Please enter the following information:");
                person.AskProperties();
                person.Save();
                Console.WriteLine("Thank you! I have saved your information for next time.");
            }

            Console.WriteLine("------------------------");

            testType = person.GetType();
            var membersInfo = testType.GetMembers();
            var methodsInfo = testType.GetMethods();
            var propertiesInfo = testType.GetProperties();
            foreach (var member in membersInfo)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine("------------------------");
            foreach (var method in methodsInfo)
            {
                Console.WriteLine(method);
            }
            Console.WriteLine("------------------------");
            foreach (var property in propertiesInfo)
            {
                Console.WriteLine(property);
            }
            Console.WriteLine("------------------------");

            var arrayList = new ArrayList {1, "star", 3.5};
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.GetType());
            }
            
            Console.ReadKey();
        }
    }

    class DummyClass
    {
        private int testValue = 42;

        public int TestMethod(int numberToAdd)
        {
            return testValue + numberToAdd;
        }
    }

    public abstract class SettingUtil
    {
        public void AskProperties()
        {
            var type = GetType();
            var properties = type.GetProperties();
            foreach (var propertyInfo in properties)
            {
                Console.WriteLine(propertyInfo.Name + ":");
                SetProperty(propertyInfo, Console.ReadLine());
            }
        }

        public void Load()
        {
            if (!File.Exists("settings.dat")) return;
            var type = GetType();

            var splitChars = new[] { '|' };

            var settings = File.ReadAllLines("settings.dat");
            foreach (var s in settings)
            {
                var temp = s.Split(splitChars);
                if (temp.Length == 2)
                {
                    var propertyName = temp[0];
                    var value = temp[1];
                    var propertyInfo = type.GetProperty(propertyName);
                    if (propertyInfo != null)
                    {
                        SetProperty(propertyInfo, value);
                    }
                }
            }
        }

        public void Save()
        {
            var type = GetType();
            var properties = type.GetProperties();
            TextWriter tw = new StreamWriter("settings.dat");
            foreach (var propertyInfo in properties)
            {
                tw.WriteLine(propertyInfo.Name + "|" + propertyInfo.GetValue(this, null));
            }
            tw.Close();
        }

        private void SetProperty(PropertyInfo propertyInfo, object value)
        {
            switch (propertyInfo.PropertyType.Name)
            {
                case "Int32":
                    propertyInfo.SetValue(this, Convert.ToInt32(value), null);
                    break;
                case "String":
                    propertyInfo.SetValue(this, value.ToString(), null);
                    break;
            }
        }
    }

    public class Person : SettingUtil
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
