/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit5TestClass.java to edit this template
 */
package DAL;

import Models.Ticket_film;
import jdk.jshell.spi.ExecutionControl;
import org.junit.Assert;
import org.junit.Test;

/**
 *
 * @author Fpt
 */
public class TicketFilmDAOGetTicketByFilmIdAndStartHourTest {
     
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC01() {
        Ticket_film expected = new Ticket_film(1, 1, 1, 1);
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1, "09:00:00");
        Assert.assertEquals(expected.toString(), actual.toString());
        
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC02() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(-1, "09:00:00");
        Assert.assertEquals(expected, actual);
        
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC03() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(2147483647, "09:00:00");
        Assert.assertEquals(expected, actual);
        
    }
    
    @Test(expected = RuntimeException.class)
    public void  TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC04() {
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(-2900000000 , "09:00:00");
    }
    
    @Test(expected = RuntimeException.class)
    public void  TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC05() {
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour("mot" , "09:00:00");
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC06() {
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(null , "09:00:00");
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC07() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1, "009:00:00");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC08() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1, "9");
        Assert.assertEquals(expected, actual);
    }
    
    @Test(expected = RuntimeException.class)
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC09() {
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1 , 9);
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC10() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1, "abcooo");
        Assert.assertEquals(expected, actual);
    }
    
    @Test
    public void TicketFilmDAOGetTicketByFilmIdAndStartHourTestUTC11() {
        Ticket_film expected = null;
        Ticket_film actual = Ticket_filmDAO.INSTANCE.getTicketByFilmIdAndStartHour(1, null);
        Assert.assertEquals(expected, actual);
    }
    
}
