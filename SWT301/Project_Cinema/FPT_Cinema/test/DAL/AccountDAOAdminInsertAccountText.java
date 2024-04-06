/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package DAL;

import Models.Ticket_film;
import org.junit.Assert;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Fpt
 */
public class AccountDAOAdminInsertAccountText {
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC01() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC02() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("ashd@#$%ff*", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminInsertAccountTextUTC03() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount(1, "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
   @Test
    public void AccountDAOAdminInsertAccountTextUTC04() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("", "123", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminInsertAccountTextUTC05() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", 123, "Phạm", "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC06() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "aaaa", "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC07() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", null, "Phạm", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC08() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "dsdhsjdjshđsds", "Phong", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminInsertAccountTextUTC09() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", 1, "Phong", "Phong@123", "123456789", "1");
    }
    
    @Test(expected = RuntimeException.class)
    public void  AccountDAOAdminInsertAccountTextUTC10() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", 1, "Phong@123", "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC11() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "sassasassasasasasas", "Phong@123", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminInsertAccountTextUTC12() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", 1, "123456789", "1");
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC13() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "aaaaaaaaaaaaaaaaaaaaa", "123456789", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminInsertAccountTextUTC14() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", 1, "1");
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC15() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", "", "1");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void AccountDAOAdminInsertAccountTextUTC16() {
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", "123456789", 0);
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC17() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", "123456789", "aaaaaa");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void AccountDAOAdminInsertAccountTextUTC18() {
        boolean expected = true;
        boolean actual = AccountDAO.INSTANCE.adminInsertAccount("admin", "123", "Phạm", "Phong", "Phong@123", "123456789", null);
        Assert.assertEquals(expected, actual);
    }
   
}
