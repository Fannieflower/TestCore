using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class QueryPoWarehouseReceiptResp {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 入库单列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt> items_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt> value){
			this.items_ = value;
		}
		
	}
	
}