using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class BatchProtContractDetailParam {
		
		///<summary>
		/// 确认函编号列表
		///</summary>
		
		private List<string> protNos_;
		
		///<summary>
		/// 查询用户数据权限
		///</summary>
		
		private List<string> dataAreaIds_;
		
		public List<string> GetProtNos(){
			return this.protNos_;
		}
		
		public void SetProtNos(List<string> value){
			this.protNos_ = value;
		}
		public List<string> GetDataAreaIds(){
			return this.dataAreaIds_;
		}
		
		public void SetDataAreaIds(List<string> value){
			this.dataAreaIds_ = value;
		}
		
	}
	
}