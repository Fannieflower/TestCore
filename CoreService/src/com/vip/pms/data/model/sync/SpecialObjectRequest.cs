using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class SpecialObjectRequest {
		
		///<summary>
		/// 营销对象基础信息
		///</summary>
		
		private com.vip.pms.data.model.sync.SpecialObjectBaseModel objectBaseModel_;
		
		///<summary>
		/// 营销对象信息(member)，下个版本去掉
		///</summary>
		
		private List<com.vip.pms.data.model.sync.ActObjectMemberModel> objectMemberModelList_;
		
		///<summary>
		/// 营销对象信息(member)
		///</summary>
		
		private com.vip.pms.data.model.sync.ActObjectMemberModel objectMemberModel_;
		
		public com.vip.pms.data.model.sync.SpecialObjectBaseModel GetObjectBaseModel(){
			return this.objectBaseModel_;
		}
		
		public void SetObjectBaseModel(com.vip.pms.data.model.sync.SpecialObjectBaseModel value){
			this.objectBaseModel_ = value;
		}
		public List<com.vip.pms.data.model.sync.ActObjectMemberModel> GetObjectMemberModelList(){
			return this.objectMemberModelList_;
		}
		
		public void SetObjectMemberModelList(List<com.vip.pms.data.model.sync.ActObjectMemberModel> value){
			this.objectMemberModelList_ = value;
		}
		public com.vip.pms.data.model.sync.ActObjectMemberModel GetObjectMemberModel(){
			return this.objectMemberModel_;
		}
		
		public void SetObjectMemberModel(com.vip.pms.data.model.sync.ActObjectMemberModel value){
			this.objectMemberModel_ = value;
		}
		
	}
	
}