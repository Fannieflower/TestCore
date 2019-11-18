using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	
	
	public class TmsOrderPageModel {
		
		///<summary>
		/// 单号规则生成模板对象List集合-当前页中存放的记录
		///</summary>
		
		private List<com.vip.top.deliveryorder.service.TmsOrderUnionModel> tmsOrderUnionModels_;
		
		///<summary>
		/// 总记录数,默认为0
		///</summary>
		
		private int? totalRecord_;
		
		public List<com.vip.top.deliveryorder.service.TmsOrderUnionModel> GetTmsOrderUnionModels(){
			return this.tmsOrderUnionModels_;
		}
		
		public void SetTmsOrderUnionModels(List<com.vip.top.deliveryorder.service.TmsOrderUnionModel> value){
			this.tmsOrderUnionModels_ = value;
		}
		public int? GetTotalRecord(){
			return this.totalRecord_;
		}
		
		public void SetTotalRecord(int? value){
			this.totalRecord_ = value;
		}
		
	}
	
}