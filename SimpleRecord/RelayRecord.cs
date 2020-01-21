using System;
namespace SimpleRecord
{
    public class RelayRecord : RecordBase
    {
        private readonly Action undo;
        private readonly Action redo;

        public RelayRecord(Action undo, Action redo) : base()
        {
            this.undo = undo;
            this.redo = redo;
        }

        public override void Redo()
        {
            redo();
        }

        public override void Undo()
        {
            undo();
        }

    }
}
