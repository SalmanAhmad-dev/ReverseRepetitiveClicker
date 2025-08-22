# **Welcome to ReverseRepetitiveClicker**

---

### **Requirements: **
 1- .NET 8.0 or Higher.
 

## **Usage**

**ReverseRepetitiveClicker** is a simple program designed to repeat a number of clicks in a **reverse manner**.  

### **How it works**
Do a left mouse button click on current mouse position.
Key "Tab"

Suppose `MaxN = 8`. The program follows this loop:

Loop:
MaxN - n (where n = number of clicks that brings the value to 1)



**Example:**

1. `8 - 7 = 1`  
2. Next loop: `7 - 6 = 1`  
3. Next loop: `6 - 5 = 1 `
4. Until MaxN == 1 it resets
> In other words, `MaxN` gets decremented each loop, and the clicks are calculated in reverse.

#### **Future Enhancements**
- [ ]  Custom Hotkey
- [ ]  Start / Stop via Hotkey
- [ ]  Logging Of Clicks

**Enjoy automating repetitive clicks with ReverseRepetitiveClicker!**
