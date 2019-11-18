using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class ActObjectUpdateRequest {
		
		///<summary>
		/// 子活动号
		///</summary>
		
		private string actNo_;
		
		///<summary>
		/// 删除的rangId
		///</summary>
		
		private List<string> delRangIdList_;
		
		///<summary>
		/// 添加的营销对象
		///</summary>
		
		private com.vip.pms.data.model.sync.ActObjectMemberModel addObjectMemberModel_;
		
		public string GetActNo(){
			return this.actNo_;
		}
		
		public void SetActNo(string value){
			this.actNo_ = value;
		}
		public List<string> GetDelRangIdList(){
			return this.delRangIdList_;
		}
		
		public void SetDelRangIdList(List<string> value){
			this.delRangIdList_ = value;
		}
		public com.vip.pms.data.model.sync.ActObjectMemberModel GetAddObjectMemberModel(){
			return this.addObjectMemberModel_;
		}
		
		public void SetAddObjectMemberModel(com.vip.pms.data.model.sync.ActObjectMemberModel value){
			this.addObjectMemberModel_ = value;
		}
		
	}
	
}