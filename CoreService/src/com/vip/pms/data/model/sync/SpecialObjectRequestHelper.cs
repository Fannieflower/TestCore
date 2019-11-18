using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class SpecialObjectRequestHelper : TBeanSerializer<SpecialObjectRequest>
	{
		
		public static SpecialObjectRequestHelper OBJ = new SpecialObjectRequestHelper();
		
		public static SpecialObjectRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpecialObjectRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("objectBaseModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.model.sync.SpecialObjectBaseModel value;
						
						value = new com.vip.pms.data.model.sync.SpecialObjectBaseModel();
						com.vip.pms.data.model.sync.SpecialObjectBaseModelHelper.getInstance().Read(value, iprot);
						
						structs.SetObjectBaseModel(value);
					}
					
					
					
					
					
					if ("objectMemberModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.model.sync.ActObjectMemberModel> value;
						
						value = new List<com.vip.pms.data.model.sync.ActObjectMemberModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.model.sync.ActObjectMemberModel elem1;
								
								elem1 = new com.vip.pms.data.model.sync.ActObjectMemberModel();
								com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetObjectMemberModelList(value);
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
		
		
		public void Write(SpecialObjectRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetObjectBaseModel() != null) {
				
				oprot.WriteFieldBegin("objectBaseModel");
				
				com.vip.pms.data.model.sync.SpecialObjectBaseModelHelper.getInstance().Write(structs.GetObjectBaseModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("objectBaseModel can not be null!");
			}
			
			
			if(structs.GetObjectMemberModelList() != null) {
				
				oprot.WriteFieldBegin("objectMemberModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.model.sync.ActObjectMemberModel _item0 in structs.GetObjectMemberModelList()){
					
					
					com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetObjectMemberModel() != null) {
				
				oprot.WriteFieldBegin("objectMemberModel");
				
				com.vip.pms.data.model.sync.ActObjectMemberModelHelper.getInstance().Write(structs.GetObjectMemberModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpecialObjectRequest bean){
			
			
		}
		
	}
	
}