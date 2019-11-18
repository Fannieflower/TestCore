using System;

namespace com.vip.vop.cup.api.product{
	
	
	public enum EventType {
		
		
		///<summary>
		/// 新建商品
		///</summary>
		PROD_CREATE = 0, 
		
		///<summary>
		/// 上下架
		///</summary>
		ON_OFF_SHELF = 1, 
		
		///<summary>
		/// 价格变化
		///</summary>
		PRICE_CHANGE = 2, 
		
		///<summary>
		/// 商品资料变化
		///</summary>
		PDC_CHANGE = 3, 
		
		///<summary>
		/// 商品资料删除
		///</summary>
		PROD_DELETE = 4 
	}
	
	public class EventTypeUtil{
		
		private readonly int value;
		private EventTypeUtil(int value){
			this.value = value;
		}
		
		public int getValue() {
			return value;
		}
		
		
		public static EventType? FindByValue(int value){
			
			switch(value){
				
				case 0: return EventType.PROD_CREATE; 
				case 1: return EventType.ON_OFF_SHELF; 
				case 2: return EventType.PRICE_CHANGE; 
				case 3: return EventType.PDC_CHANGE; 
				case 4: return EventType.PROD_DELETE; 
				
				default: return null; 
				
			}
			
		}
		
		public static EventType? FindByName(string name){
			
			if(EventType.PROD_CREATE.ToString().Equals(name)){
				
				return EventType.PROD_CREATE; 
			}
			
			if(EventType.ON_OFF_SHELF.ToString().Equals(name)){
				
				return EventType.ON_OFF_SHELF; 
			}
			
			if(EventType.PRICE_CHANGE.ToString().Equals(name)){
				
				return EventType.PRICE_CHANGE; 
			}
			
			if(EventType.PDC_CHANGE.ToString().Equals(name)){
				
				return EventType.PDC_CHANGE; 
			}
			
			if(EventType.PROD_DELETE.ToString().Equals(name)){
				
				return EventType.PROD_DELETE; 
			}
			
			
			return null;
			
		}
		
	}
	
}