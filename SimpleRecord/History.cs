using System.Collections.Generic;
namespace SimpleRecord
{
    public class History
    {
        Stack<RecordBase> redoStack = new Stack<RecordBase>();
        Stack<RecordBase> undoStack = new Stack<RecordBase>();

        public void Add(RecordBase record)
        {
            undoStack.Push(record);
            redoStack.Clear();
        }

        public void Undo()
        {
            var record = undoStack.Pop();
            record.Undo();

            redoStack.Push(record);
        }

        public void Redo()
        {
            var record = redoStack.Pop();
            record.Redo();

            undoStack.Push(record);
        }
    }
}
