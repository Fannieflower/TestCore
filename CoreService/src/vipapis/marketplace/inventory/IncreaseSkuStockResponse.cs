using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.inventory{
	
	
	
	
	
	public class IncreaseSkuStockResponse {
		
		///<summary>
		/// 库存更新结果：true代表成功，或部分成功(调减时，如果 “Leavings” < “欲调减的库存数（入参取绝对值）”，则会出现“部分成功”的情况)；false代表失败
		///</summary>
		
		private bool? success_;
		
		///<summary>
		/// 可能超卖的数量，大于0表示目前可能已超卖。
		///</summary>
		
		private int? over_sell_quantity_;
		
		public bool? GetSuccess(){
			return this.success_;
		}
		
		public void SetSuccess(bool? value){
			this.success_ = value;
		}
		public int? GetOver_sell_quantity(){
			return this.over_sell_quantity_;
		}
		
		public void SetOver_sell_quantity(int? value){
			this.over_sell_quantity_ = value;
		}
		
	}
	
}