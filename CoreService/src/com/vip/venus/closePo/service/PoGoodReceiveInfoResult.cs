using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.closePo.service{
	
	
	
	
	
	public class PoGoodReceiveInfoResult {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string po_;
		
		///<summary>
		/// 条码级别收货信息
		///</summary>
		
		private List<com.vip.venus.closePo.service.ItemReceiveInfo> itemRecQtyList_;
		
		public string GetPo(){
			return this.po_;
		}
		
		public void SetPo(string value){
			this.po_ = value;
		}
		public List<com.vip.venus.closePo.service.ItemReceiveInfo> GetItemRecQtyList(){
			return this.itemRecQtyList_;
		}
		
		public void SetItemRecQtyList(List<com.vip.venus.closePo.service.ItemReceiveInfo> value){
			this.itemRecQtyList_ = value;
		}
		
	}
	
}