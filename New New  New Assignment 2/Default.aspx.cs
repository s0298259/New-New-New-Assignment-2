using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace New_New__New_Assignment_2
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmmm        Clear Method         mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        public void clearMethod()
        {
            stereoSystemCheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            gpsCheckBox.Checked = false;
            standardRadioButton.Checked = false;
            if (standardRadioButton.Checked) standardRadioButton.Checked = false;
            else if (modifiedRadioButton.Checked) modifiedRadioButton.Checked = false;
            else if (customizedRadioButton.Checked) customizedRadioButton.Checked = false;


            //add other false

        } //end of Method Clear

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmmm      Set Standard values    mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        public void setStdValues()
        {
            basicPriceTextBox.Text = "0";
            tradeInTextBox.Text = "0";
            access1Textbox.Text = "30.50";
            access2Textbox.Text = "530.99";
            access3Textbox.Text = "301.99";
            standardTextBox.Text = "0";
            modifiedTextBox.Text = "370.50";
            customTextBox.Text = "1257.99";
            VATTextBox.Text = "6";
        } //end of Method Set Standard values 

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmmm     Basic Price  Method     mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        public double basicPrice()
        {
            double basicPriceVar = 0;
            if (!Double.TryParse(basicPriceTextBox.Text, out basicPriceVar))
                return 0; // If nonsensical value entered return value 0

            return basicPriceVar; // return basicPriceVar

        } //end of Method Basic Price

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmm    Trade In Price  Method    mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm  
        public double tradeInPrice()
        {
            double tradeInPriceVar = 0;
            if (!Double.TryParse(tradeInTextBox.Text, out tradeInPriceVar))
                return 0; // If nonsensical value entered return value 0

            return tradeInPriceVar; // return tradeInPriceVar

        } //end of Method Trade In Price

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmm  Checkbox Method     mmmmmmm
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm 
        public double Chkbox()
        {
            double Chkbox_1 = 0; double Chkbox_2 = 0; double Chkbox_3 = 0;
            Chkbox_1 = stereoSystemCheckBox.Checked ? Chkbox_1 = double.Parse(access1Textbox.Text) : Chkbox_1; // Ternary
            Chkbox_2 = leatherInteriorCheckBox.Checked ? Chkbox_2 = double.Parse(access2Textbox.Text) : Chkbox_2; // // Ternary
            Chkbox_3 = gpsCheckBox.Checked ? Chkbox_3 = double.Parse(access3Textbox.Text) : Chkbox_3; // // Ternary
            return Chkbox_1 + Chkbox_2 + Chkbox_3; //add them all together
        } //end of Method Checkbox Method

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmm Radio Buttons Method mmmmmmm
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm 
        public double radioButtons()
        {
            double radioButtonsVar = 0;
            if (modifiedRadioButton.Checked && !Double.TryParse(modifiedTextBox.Text, out radioButtonsVar)) // If radiobutton checked and sensible value entered
                return 0; // If nonsensical value entered return value 0                    
            else if (customizedRadioButton.Checked && !Double.TryParse(customTextBox.Text, out radioButtonsVar)) // If radiobutton checked and sensible value entered
                return 0; // If nonsensical value entered return value 0
            else return radioButtonsVar; // return basicPriceVar
        } //end of Method Radio Buttons

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmm         VAT  Method          mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm  
        public double vatMethod()
        {
            double VAT = 0;
            if (!Double.TryParse(VATTextBox.Text, out VAT)) // check tvat
                return 0; // If nonsensical value entered return value 0

            return VAT; // return basicPriceVar

        } //end of VAT  Method   

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmm      Display Total Method    mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm  
        public void dsply_total(double subTotal, double VAT, double total)
        {
            //   resultLabel.Text = String.Format ("{0:C}",total);

            //resultLabel.Text = "TOTAL " + total.ToString() + "    VAT" + (VAT / 100) * total.ToString();



        } //end of Method Trade Display Total                                

        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm
        //mmmmmm      Check Form Ok Method    mmmmmmm  
        //mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm 
        private bool CheckFormIsOk() // Check the textboxes have a value eneterd
        {
            if (basicPriceTextBox.Text.Trim().Length == 0) return false;
            if (tradeInTextBox.Text.Trim().Length == 0) return false;
            if (access1Textbox.Text.Trim().Length == 0) return false;
            if (access2Textbox.Text.Trim().Length == 0) return false;
            if (access3Textbox.Text.Trim().Length == 0) return false;
            if (standardTextBox.Text.Trim().Length == 0) return false;
            if (modifiedTextBox.Text.Trim().Length == 0) return false;
            if (customTextBox.Text.Trim().Length == 0) return false;
            else return true;
        } // end of method CheckFormIsOk


        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        //bbbbbbb   Calculate Button Press    bbbbbbb  
        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = ""; // clear resultLabel

            double basicPriceVar;// setup variable basicPriceVar
            double tradeInPriceVar;// setup variable tradeInPriceVar
            double chkBoxTotalVar;// setup variable chkBoxTotalVar
            double radioButtonsVar; // setup variable radioButtonsVar    

            double subtotal;
            double total; // setup datatype double called "total"  
            double VAT; // setup variabl VAT 

            String Password = PassTextBox.Text;

            if (Password != "Password1234")
            { // if Password not entered reset default 
                setStdValues();
            }

            bool formOk; // bool false true used for checking if textboxes have a value entered

            formOk = CheckFormIsOk(); //formOk = method  CheckFormIsOk true or false

            if (formOk) // if bool formOk is true
            {
                basicPriceVar = basicPrice();// basicPriceVar = Method Basic Price
                tradeInPriceVar = tradeInPrice(); // tradeInPriceVar = subtract Trade In Price
                chkBoxTotalVar = Chkbox();// chkBoxTotalVar = add Checkbox total            
                radioButtonsVar = radioButtons(); // radioButtonsVar = add radio buttons total
                VAT = vatMethod();



                // total = (basicPriceVar - tradeInPriceVar);
                // total = total + (radioButtonsVar + chkBoxTotalVar);
                //   total = total + (total * VAT); // add VAT to the total

                subtotal = (basicPriceVar + (radioButtonsVar + chkBoxTotalVar));
                subTotalLabel.Text = String.Format("{0:C}", subtotal);
                //  VAT = (subtotal * (VAT / 100));
                vatLabel.Text = String.Format("{0:C}", subtotal * (VAT / 100) + "     at " + VAT + "%");

                total = subtotal + ((subtotal * (VAT / 100)) - tradeInPriceVar);
                resultLabel.Text = String.Format("{0:C}", total + " minus trade in and including VAT");

                // dsply_total(subtotal,VAT,total);// total display total with Method
            }
        }// END Button

        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        //bbbbbbb     Reset Button Press      bbbbbbb  
        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        protected void resetButton_Click(object sender, EventArgs e)
        {
            setStdValues();
        }// END Button

        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        //bbbbbbb     Clear Button Press      bbbbbbb  
        //bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb
        protected void clearButton_Click(object sender, EventArgs e)
        {
            clearMethod();
        }// END Button








    }
}