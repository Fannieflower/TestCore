using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class ActObjectRequest {
		
		///<summary>
		/// 营销对象基础信息
		///</summary>
		
		private com.vip.pms.data.model.sync.ActObjectBaseModel objectBaseModel_;
		
		///<summary>
		/// 营销对象信息(member)
		///</summary>
		
		private com.vip.pms.data.model.sync.ActObjectMemberModel objectMemberModel_;
		
		public com.vip.pms.data.model.sync.ActObjectBaseModel GetObjectBaseModel(){
			return this.objectBaseModel_;
		}
		
		public void SetObjectBaseModel(com.vip.pms.data.model.sync.ActObjectBaseModel value){
			this.objectBaseModel_ = value;
		}
		public com.vip.pms.data.model.sync.ActObjectMemberModel GetObjectMemberModel(){
			return this.objectMemberModel_;
		}
		
		public void SetObjectMemberModel(com.vip.pms.data.model.sync.ActObjectMemberModel value){
			this.objectMemberModel_ = value;
		}
		
	}
	
}