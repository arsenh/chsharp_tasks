using System;
using System.Collections.Generic;

namespace TaskThree
{

    /// Задача - перепишите данный код так, чтобы он работал через коллекции C#, вместо конструкции switch


    public enum ActionType
    {
        Create,

        Read,

        Update,

        Delete,
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var type = ActionType.Read;
            var actions = new Dictionary<ActionType, Action<ActionType>>()
            {
                { ActionType.Create, new Action<ActionType>(CreateMethod) },
                { ActionType.Read, new Action<ActionType>(ReadMethod) },
                { ActionType.Update, new Action<ActionType>(UpdateMethod) },
                { ActionType.Delete, new Action<ActionType>(DeleteMethod) },
            };

            bool ret = false;
            ret = actions.TryGetValue(type, out Action<ActionType> action);
            if (ret)
            {
                action.Invoke(type);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static void CreateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void ReadMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void UpdateMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }

        private static void DeleteMethod(ActionType type)
        {
            Console.WriteLine(type.ToString());
        }
    }
}
