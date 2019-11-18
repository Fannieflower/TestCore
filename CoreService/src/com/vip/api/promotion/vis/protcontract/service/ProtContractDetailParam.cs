using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDetailParam {
		
		///<summary>
		/// 确认函id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 确认函编号（没有id时按编号查询）
		///</summary>
		
		private string protNo_;
		
		///<summary>
		/// 查询用户数据权限
		///</summary>
		
		private List<string> dataAreaIds_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public string GetProtNo(){
			return this.protNo_;
		}
		
		public void SetProtNo(string value){
			this.protNo_ = value;
		}
		public List<string> GetDataAreaIds(){
			return this.dataAreaIds_;
		}
		
		public void SetDataAreaIds(List<string> value){
			this.dataAreaIds_ = value;
		}
		
	}
	
}