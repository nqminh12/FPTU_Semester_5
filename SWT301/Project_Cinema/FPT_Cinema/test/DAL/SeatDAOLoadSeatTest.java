/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/UnitTests/JUnit4TestClass.java to edit this template
 */
package DAL;

import Models.Seat;
import java.util.List;
import org.junit.Assert;
import org.junit.Test;
import static org.junit.Assert.*;

/**
 *
 * @author Fpt
 */
public class SeatDAOLoadSeatTest {

    @Test
    public void SeatDAOLoadSeatTestUTC01() {
        String expected = "[Seat{id=1, seat_number=A1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=2, seat_number=A2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=3, seat_number=A3, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=4, seat_number=A4, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=5, seat_number=A5, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=6, seat_number=A6, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=7, seat_number=A7, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=8, seat_number=A8, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=9, seat_number=A9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=10, seat_number=A10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=11, seat_number=B1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=12, seat_number=B2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=13, seat_number=B3, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=14, seat_number=B4, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=15, seat_number=B5, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=16, seat_number=B6, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=17, seat_number=B7, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=18, seat_number=B8, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=19, seat_number=B9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=20, seat_number=B10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=21, seat_number=C1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=22, seat_number=C2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=23, seat_number=C3, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=24, seat_number=C4, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=25, seat_number=C5, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=26, seat_number=C6, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=27, seat_number=C7, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=28, seat_number=C8, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=29, seat_number=C9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=30, seat_number=C10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=121, seat_number=D1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=122, seat_number=D2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=123, seat_number=D3, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=124, seat_number=D4, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=125, seat_number=D5, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=126, seat_number=D6, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=127, seat_number=D7, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=128, seat_number=D8, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=129, seat_number=D9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=130, seat_number=D10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=131, seat_number=E1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=132, seat_number=E2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=133, seat_number=E3, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=134, seat_number=E4, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=135, seat_number=E5, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=136, seat_number=E6, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=137, seat_number=E7, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=138, seat_number=E8, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=139, seat_number=E9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=140, seat_number=E10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=141, seat_number=F1, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=142, seat_number=F2, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=143, seat_number=F3, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=144, seat_number=F4, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=145, seat_number=F5, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=146, seat_number=F6, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=147, seat_number=F7, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=148, seat_number=F8, type=VIP, price=150000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=149, seat_number=F9, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}, Seat{id=150, seat_number=F10, type=Standard, price=100000, room_id=Seat{id=1, name=Room A, capacity=30}}]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1, "09:00:00");
        Assert.assertEquals(expected, actual.toString());
    }

    @Test
    public void SeatDAOLoadSeatTestUTC02() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(-1, "09:00:00");
        Assert.assertEquals(expected, actual.toString());
    }
    
    @Test
    public void SeatDAOLoadSeatTestUTC03() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(2147483647, "09:00:00");
        Assert.assertEquals(expected, actual.toString());
    }
    
    @Test(expected = RuntimeException.class)
    public void SeatDAOLoadSeatTestUTC04() {
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(-2900000000, "09:00:00");
    }
    
    @Test(expected = RuntimeException.class)
    public void SeatDAOLoadSeatTestUTC05() {
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat("mot", "09:00:00");
    }
    
    @Test(expected = RuntimeException.class)
    public void SeatDAOLoadSeatTestUTC06() {
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(null , "09:00:00");
    }
    
    @Test
    public void SeatDAOLoadSeatTestUTC07() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1, "009:00:00");
        Assert.assertEquals(expected, actual.toString());
    }
    
    @Test
    public void SeatDAOLoadSeatTestUTC08() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1, "9");
        Assert.assertEquals(expected, actual.toString());
    }
    
    @Test(expected = RuntimeException.class)
    public void SeatDAOLoadSeatTestUTC09() {
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1 , 9);
    }
    
    @Test
    public void SeatDAOLoadSeatTestUTC10() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1, "abcooo");
        Assert.assertEquals(expected, actual.toString());
    }
    
    @Test
    public void SeatDAOLoadSeatTestUTC11() {
        String expected = "[]";
        List<Seat> actual = SeatDAO.INSTANCE.loadSeat(1, null);
        Assert.assertEquals(expected, actual.toString());
    }
}
