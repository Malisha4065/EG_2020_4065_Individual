
using CommunityToolkit.Mvvm.Messaging.Messages;
using individual.Models;

namespace individual.Messenger
{
    public class PersonMessenger : ValueChangedMessage<Student>
    {
        public PersonMessenger(Student value) : base(value)
        {
        }
    }

    public class EditPersonMessenger : ValueChangedMessage<Student>
    {
        public EditPersonMessenger(Student value) : base(value)
        {
        }
    }

    public class SendBackEditPersonMessenger : ValueChangedMessage<Student>
    {
        public SendBackEditPersonMessenger(Student value) : base(value)
        {
        }
    }
}
