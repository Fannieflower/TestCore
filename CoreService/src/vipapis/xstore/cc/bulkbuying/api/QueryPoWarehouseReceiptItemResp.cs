using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class QueryPoWarehouseReceiptItemResp {
		
		///<summary>
		/// 总记录数
		///</summary>
		
		private int? total_;
		
		///<summary>
		/// 入库单列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem> items_;
		
		public int? GetTotal(){
			return this.total_;
		}
		
		public void SetTotal(int? value){
			this.total_ = value;
		}
		public List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem> GetItems(){
			return this.items_;
		}
		
		public void SetItems(List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem> value){
			this.items_ = value;
		}
		
	}
	
}