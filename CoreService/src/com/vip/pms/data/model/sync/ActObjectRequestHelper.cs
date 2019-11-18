using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class ActObjectRequestHelper : TBeanSerializer<ActObjectRequest>
	{
		
		public static ActObjectRequestHelper OBJ = new ActObjectRequestHelper();
		
		public static ActObjectRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActObjectRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("objectBaseModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.model.sync.ActObjectBaseModel value;
						
						value = new com.vip.pms.data.model.sync.ActObjectBaseModel();
						com.vip.pms.data.model.sync.ActObjectBaseModelHelper.getInstance().Read(value, iprot);
						
						structs.SetObjectBaseModel(value);
					}
					
					
					
					
					
					if ("objectMemberModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.model.sync.ActObjectMemberModel value;
						
						value = new com.vip.pms.data.model.sync.ActObjectMemberModel();
						com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Read(value, iprot);
						
						structs.SetObjectMemberModel(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(ActObjectRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetObjectBaseModel() != null) {
				
				oprot.WriteFieldBegin("objectBaseModel");
				
				com.vip.pms.data.model.sync.ActObjectBaseModelHelper.getInstance().Write(structs.GetObjectBaseModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("objectBaseModel can not be null!");
			}
			
			
			if(structs.GetObjectMemberModel() != null) {
				
				oprot.WriteFieldBegin("objectMemberModel");
				
				com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Write(structs.GetObjectMemberModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("objectMemberModel can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActObjectRequest bean){
			
			
		}
		
	}
	
}