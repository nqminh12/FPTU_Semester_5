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
public class TicketFilmDAOInsertTicketTest {

    @Test
    public void TicketFilmDAOInsertTicketTestUTC01() {
        boolean expected = true;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket(1, 1, 1);
        Assert.assertEquals(expected, actual);        
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC02() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( -1, 1, 1);
        Assert.assertEquals(expected, actual);     
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC03() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 100, 1, 1);
        Assert.assertEquals(expected, actual);       
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC04() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 30000000000000, 1, 1);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC05() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( "abcs", 1, 1);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC06() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( null, 1, 1);
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC07() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, -5, 1);
        Assert.assertEquals(expected, actual);       
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC08() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 400, 1);
        Assert.assertEquals(expected, actual);       
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC09() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 32323232323232323, 1);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC10() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, "hello", 1);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC11() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, null, 1);
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC12() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 1, -20);
        Assert.assertEquals(expected, actual);       
    }
    
    @Test
    public void TicketFilmDAOInsertTicketTestUTC13() {
        boolean expected = false;
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 1, 300);
        Assert.assertEquals(expected, actual);       
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC14() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 1, 1111111111111111);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC15() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 1, "aaa");
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOInsertTicketTestUTC16() {
        boolean actual = Ticket_filmDAO.INSTANCE.insertTicket( 1, 1, null);
    }
}
