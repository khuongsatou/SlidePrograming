<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>My Guitar Shop</title>
    <link rel="stylesheet" type="text/css" href="main.css"/>
</head>
<body>
    <div id="page">
        <div id="header">
            <h1>My Guitar Shop</h1>
        </div>
        <div id="main">

            <h1>Your Cart</h1>
                <form action="." method="post">
                <input type="hidden" name="action" value="update"/>
                <table>
                    <tr id="cart_header">
                        <th class="left">Item</th>
                        <th class="right">Item Cost</th>
                        <th class="right">Quantity</th>
                        <th class="right">Item Total</th>
                    </tr>
                        
                         <?php 
                            foreach ($cart as $id => $items) {
                                $name = $items['name'];
                                $cost = $items['cost'];
                                $quanlity = $items['quanlity'];
                                $total = $cost * $quanlity; 

                         ?>
                        <tr>
                            <td>
                                <?php echo $name; ?>
                            </td>
                            <td class="right">
                                <?php echo $cost ?>
                            </td>
                            <td class="right">
                                <input type="text" class="cart_qty"
                                    name="quantity_model_1"
                                    value="<?php echo $quanlity; ?>"/>
                            </td>
                            <td class="right">
                                 <?php echo $total; ?>
                            </td>
                        </tr>


                         <?php } ?>
                    
                    <tr id="cart_footer">
                        <td colspan="3"><b>Subtotal</b></td>
                        <td>6000</td>
                    </tr>
                    <tr>
                        <td colspan="4" class="right">
                            <input type="submit" value="Update Cart"/>
                        </td>
                    </tr>
                </table>
                <p>Click "Update Cart" to update quantities in your
                    cart. Enter a quantity of 0 to remove an item.
                </p>
                </form>
            <p><a href=".?action=show_add_item">Add Item</a></p>
            <p><a href=".?action=empty_cart">Empty Cart</a></p>

        </div><!-- end main -->
    </div><!-- end page -->
</body>
</html>
