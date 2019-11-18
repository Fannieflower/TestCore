using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.inventory{
	
	
	
	
	
	public class GetCooperationNoListResponse {
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? has_next_;
		
		///<summary>
		/// 合作编码信息列表
		///</summary>
		
		private List<vipapis.inventory.CooperationNo> cooperation_no_list_;
		
		public bool? GetHas_next(){
			return this.has_next_;
		}
		
		public void SetHas_next(bool? value){
			this.has_next_ = value;
		}
		public List<vipapis.inventory.CooperationNo> GetCooperation_no_list(){
			return this.cooperation_no_list_;
		}
		
		public void SetCooperation_no_list(List<vipapis.inventory.CooperationNo> value){
			this.cooperation_no_list_ = value;
		}
		
	}
	
}