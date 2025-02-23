using UnityEngine;

namespace MarkupAttributes.Samples
{
    public class MarkedUpFieldSample : SamplesBehaviour
    {
        [MarkedUpField]
        public SomeSerializedClass normal;

        [MarkedUpField(indentChildren: false)]
        public SomeSerializedClass noChildrenIndent;

        [Box("No Control", labeled: true)]
        [MarkedUpField(showControl: false, indentChildren: false)]
        public SomeSerializedClass noControl;
    }

    [System.Serializable]
    public class SomeSerializedClass
    {
        public bool boolean;

        [EnableIfGroup("", nameof(boolean))]
        [TitleGroup("./Enabled If Boolean")]
        public int one;
        public int two;
        public int three;
    }
}
