// Wrap in a namespace to avoid conflicts
window.printHelper = {
    printContent: function (elementId) {
        try {
            // 1. Validate the element exists
            const element = document.getElementById(elementId);
            if (!element) {
                throw new Error(`Element with ID '${elementId}' not found`);
            }

            // 2. Try to open print window
            const printWindow = window.open('', '_blank', 'width=800,height=600');
            if (!printWindow) {
                throw new Error('Popup blocked! Please allow popups for printing.');
            }

            // 3. Create proper HTML structure
            printWindow.document.write(`
                <!DOCTYPE html>
                <html>
                    <head>
                        <title>Print Label</title>
                        <style>
                            body { 
                                font-family: Arial, sans-serif; 
                                padding: 20px;
                                margin: 0;
                            }
                            * {
                                box-sizing: border-box;
                            }
                        </style>
                    </head>
                    <body>
                        ${element.innerHTML}
                    </body>
                </html>
            `);
            printWindow.document.close();

            // 4. Handle printing with proper timing
            return new Promise((resolve, reject) => {
                printWindow.onload = function() {
                    try {
                        // Small delay to ensure content renders
                        setTimeout(() => {
                            try {
                                printWindow.focus();
                                printWindow.print();
                                
                                // Close after printing (with delay)
                                setTimeout(() => {
                                    printWindow.close();
                                    resolve(true);
                                }, 500);
                            } catch (printError) {
                                printWindow.close();
                                reject(new Error('Print command failed: ' + printError.message));
                            }
                        }, 200);
                    } catch (loadError) {
                        printWindow.close();
                        reject(new Error('Content load failed: ' + loadError.message));
                    }
                };

                // Fallback if onload doesn't fire
                setTimeout(() => {
                    if (printWindow.document.readyState === 'complete') {
                        printWindow.focus();
                        printWindow.print();
                        setTimeout(() => printWindow.close(), 500);
                        resolve(true);
                    }
                }, 1000);
            });
        } catch (error) {
            console.error('Printing failed:', error);
            throw error; // Re-throw to propagate to Blazor
        }
    }
};