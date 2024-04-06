/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package DAL;

import org.junit.Assert;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Fpt
 */
public class AccountDAOAdminUpdateAccountTest {
    
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC01() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC02() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(-2147483648, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC03() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(32323232323232323232323232, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC04() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount("aaaaaaaaa", "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC05() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(null , "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC06() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1,"ashd@#$%ff*", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC07() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, 1, "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
   @Test
    public void AccountDAOAdminUpdateAccountTestUTC08() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC09() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", 123, "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC10() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "aaaa", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC11() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", null, "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC12() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "dsdhsjdjshđsds", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC13() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", 1, "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminUpdateAccountTestUTC14() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", 1, "Phong@123", "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC15() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "sassasassasasasasas", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminUpdateAccountTestUTC16() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", 1, "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC17() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "aaaaaaaaaaaaaaaaaaaaa", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminUpdateAccountTestUTC18() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", 1, "1");
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC19() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", "", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminUpdateAccountTestUTC20() {
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", 0);
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC21() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "aaaaaa");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminUpdateAccountTestUTC22() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminUpdateAccount(1, "admin", "123", "Phạm", "Phong", "Phong@123", "123456789", null);
        Assert.assertEquals(expected, actual);
    }
    
}
