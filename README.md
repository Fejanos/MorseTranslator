# Morse Translator 🔡 ➝ ▄ ▄▄▄ ▄▄

A simple C# .NET console application that translates between **text** and **Morse code**.  
The app follows an **MVC structure** and saves translations into a JSON file.  

---

## Features
- 🔤 **Text → Morse** conversion
- ▄ **Morse → Text** conversion
- 📂 **JSON storage** of translations (input + output)
- 🗂 **MVC architecture** (`Model`, `View`, `Controller`, `Data`)
- 🎯 Easy to extend (new symbols, UI, or export format)

---

## How to run
1. Clone the repository:
```bash
   git clone https://github.com/<your-username>/MorseTranslator.git
   cd MorseTranslator
```
2. Run the app:
```bash
    dotnet run
```
3. Menu options:
```bash
    #===================== Morse menu =====================#
    1. Text to Morse
    2. Morse to Text
    0. Exit
 ```

---

### Example
Text → Morse
```bash
Text: HELLO WORLD
Morse: .... . .-.. .-.. --- / .-- --- .-. .-.. -..
```
Morse → Text
```bash
Morse: .... . .-.. .-.. --- / .-- --- .-. .-.. -..
Text: HELLO WORLD
```

--- 

### Morse table format (`morse.json`)
The application loads the Morse alphabet from a JSON file.  
Each entry contains a character (`Letter`) and its Morse code (`Morse`).  

Example:
```json
[
  { "Letter": "A", "Morse": ".-" },
  { "Letter": "B", "Morse": "-..." },
  { "Letter": "C", "Morse": "-.-." },
  { "Letter": "D", "Morse": "-.." },
  { "Letter": "E", "Morse": "." },
  ...
]
```

--- 

### JSON output format
Saved in output.json:
```json
[
  {
    "Text": "HELLO WORLD",
    "Morse": ".... . .-.. .-.. --- / .-- --- .-. .-.. -.."
  }
]
```

---

## License
This project is licensed under the MIT License.
See the [**LICENSE**](./LICENSE) file for details.