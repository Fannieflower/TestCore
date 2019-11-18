using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class BatchProtContractDetailModel {
		
		///<summary>
		/// 确认函主体
		///</summary>
		
		private com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel mainInfo_;
		
		public com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel GetMainInfo(){
			return this.mainInfo_;
		}
		
		public void SetMainInfo(com.vip.api.promotion.vis.protcontract.service.ProtContractMainInfoModel value){
			this.mainInfo_ = value;
		}
		
	}
	
}