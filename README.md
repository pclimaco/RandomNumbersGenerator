<h3 align="left">.RandomNumbersGenerator</h3>
<hr> 
<h4 align="left">Project description:</h3>
<p align="left">
    The scope of this project is to generate a list of 10,000 numbers in random order each time it is run. 
    <br>
    Each number in the list must be unique and be between 1 and 10,000 (inclusive).
</p>
<h4 align="left">Project content:</h3>
<p align="left">
    - API layer: <strong>NumberGeneratorController</strong>
    <br>
    - Service layer: <strong>NumberGeneratorService</strong> 
    <br>
    - Unit test: <strong>NumberGeneratorServiceTest</strong> 
</p>
<h4 align="left">How to use:</h3>
<p align="left">
    1. Ensure you have .NET 6 installed in your computer.
    <br>
    2. Clone this repository.
    <br>
    3. Through the command prompt navigate to the solution directory, e.g. ~\Repos\RandomNumbersGenerator.
    <br>
    4. <strong>Type dotnet publish.</strong>
    <br>
    5. Navigate to the binaries folder, e.g. ~\Repos\RandomNumbersGenerator\RandomNumbersGenerator\bin\Debug\net6.0.
    <br>
    6. <strong>Type dotnet RandomNumbersGenerator.dll.</strong>
    <br>
    7. The application should execute through Kestrel web server and have the it available to access through the browser.
    <br>
    8. Open your browser and navigate to http://localhost:5000/randomize.
</p>
