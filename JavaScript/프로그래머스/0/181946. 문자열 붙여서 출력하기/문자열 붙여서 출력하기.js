    const readline = require("readline");
    const rlInterface = readline.createInterface({
        input: process.stdin,
        output: process.stdout
    })

    let input = []

    rlInterface.on("line", line => {
        input = line.split(' ');
        rlInterface.close()
    });

    let c = "";
    rlInterface.on("close", () => {
        for (const inputElement of input) {
            c += inputElement;
        }
        console.log(c);
    })