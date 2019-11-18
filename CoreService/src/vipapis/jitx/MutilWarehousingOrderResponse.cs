using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class MutilWarehousingOrderResponse {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 寻仓订单列表
		///</summary>
		
		private List<vipapis.jitx.MutilWarehousingOrder> mutil_warehousing_orders_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.jitx.MutilWarehousingOrder> GetMutil_warehousing_orders(){
			return this.mutil_warehousing_orders_;
		}
		
		public void SetMutil_warehousing_orders(List<vipapis.jitx.MutilWarehousingOrder> value){
			this.mutil_warehousing_orders_ = value;
		}
		
	}
	
}