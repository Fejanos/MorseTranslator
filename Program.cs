using Morze1.Model;
using Morze1.View;
using Morze1.Data;
using Morze1.Controller;

MorseView view = new MorseView();
FileStorage storage = new FileStorage();
MorseController controller = new MorseController(view, storage);

controller.Run();