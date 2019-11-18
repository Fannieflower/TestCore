using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class PoCloseForWmsParam {
		
		///<summary>
		/// 拉取开始节点
		///</summary>
		
		private long? maxId_;
		
		///<summary>
		/// 步长
		///</summary>
		
		private long? count_;
		
		///<summary>
		/// 仓库、销售区域
		///</summary>
		
		private List<string> saleAreaList_;
		
		public long? GetMaxId(){
			return this.maxId_;
		}
		
		public void SetMaxId(long? value){
			this.maxId_ = value;
		}
		public long? GetCount(){
			return this.count_;
		}
		
		public void SetCount(long? value){
			this.count_ = value;
		}
		public List<string> GetSaleAreaList(){
			return this.saleAreaList_;
		}
		
		public void SetSaleAreaList(List<string> value){
			this.saleAreaList_ = value;
		}
		
	}
	
}