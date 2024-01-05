using UiPath.CodedWorkflows.DescriptorIntegration;

namespace Coded_Automation.ObjectRepository
{
    public static class Descriptors
    {
        public static class MyCRM
        {
            public static _Implementation._MyCRM.__Main Main { get; private set; } = new _Implementation._MyCRM.__Main();
        }
    }
}

namespace Coded_Automation._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _MyCRM._Main
    {
        public class __FirstName : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __FirstName(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/uV58qfxBEUq2gB5Vd5aLwQ", DisplayName = "FirstName", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main
    {
        public class __LastName : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LastName(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/gKBr-aKqWEORdbIH2pjxig", DisplayName = "LastName", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main
    {
        public class __OkButton : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __OkButton(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/5sDa_N4GckqOU6oxeqyELQ", DisplayName = "OkButton", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main
    {
        public class __OrderTab : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __OrderTab(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/hIO-ieb2WEynjdhBOSzYRw", DisplayName = "OrderTab", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main
    {
        public class __SaveButton : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SaveButton(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/vIE2GH9yAkegioXQN5o8sQ", DisplayName = "SaveButton", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main._State
    {
        public class __Select_Item : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Select_Item(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/i2K_UZA800eq0YEFgCE_uw", DisplayName = "Select Item", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _MyCRM._Main
    {
        public class __State : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __State(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/7BxlAV7DwUS4FnksbVZbiQ", DisplayName = "State", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Select_Item = new _Implementation._MyCRM._Main._State.__Select_Item(screenDescriptor, this);
            }

            public _Implementation._MyCRM._Main._State.__Select_Item Select_Item { get; private set; }
        }
    }

    namespace _MyCRM
    {
        public class __Main : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Main()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "ilbtc8n4xEyEbF1_gU3bIg/mxs6DLyGdEG9YSqCKg-qjg", DisplayName = "Main", Screen = this};
                FirstName = new _Implementation._MyCRM._Main.__FirstName(this, null);
                LastName = new _Implementation._MyCRM._Main.__LastName(this, null);
                OkButton = new _Implementation._MyCRM._Main.__OkButton(this, null);
                OrderTab = new _Implementation._MyCRM._Main.__OrderTab(this, null);
                SaveButton = new _Implementation._MyCRM._Main.__SaveButton(this, null);
                State = new _Implementation._MyCRM._Main.__State(this, null);
            }

            public _Implementation._MyCRM._Main.__FirstName FirstName { get; private set; }

            public _Implementation._MyCRM._Main.__LastName LastName { get; private set; }

            public _Implementation._MyCRM._Main.__OkButton OkButton { get; private set; }

            public _Implementation._MyCRM._Main.__OrderTab OrderTab { get; private set; }

            public _Implementation._MyCRM._Main.__SaveButton SaveButton { get; private set; }

            public _Implementation._MyCRM._Main.__State State { get; private set; }
        }
    }
}