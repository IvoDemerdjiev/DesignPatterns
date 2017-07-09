using System;

namespace BridgeDP
{
    public abstract class DataObject
    {
        public abstract void NextRecord();

        public abstract void PriorRecord();

        public abstract void AddRecord(string customer);

        public abstract void DeleteRecord(string customer);

        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}