using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class BatchConfirmDeliveryResult {
		
		///<summary>
		/// 操作异常数据
		///</summary>
		
		private List<vipapis.order.ConfirmDeliveryFailItem> data_;
		
		public List<vipapis.order.ConfirmDeliveryFailItem> GetData(){
			return this.data_;
		}
		
		public void SetData(List<vipapis.order.ConfirmDeliveryFailItem> value){
			this.data_ = value;
		}
		
	}
	
}