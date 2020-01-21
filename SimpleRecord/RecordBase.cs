using System;

namespace SimpleRecord
{
    public abstract class RecordBase
    {
        protected RecordBase()
        {
            TimeStamp = DateTime.Now;
        }

        /// <summary>
        /// Recordが生成されたタイムスタンプ
        /// </summary>
        public DateTime TimeStamp { get; }
        /// <summary>
        /// 元に戻す
        /// </summary>
        public abstract void Redo();
        /// <summary>
        /// やり直す
        /// </summary>
        public abstract void Undo();
    }
}
