using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class ActObjectMemberModelHelper : TBeanSerializer<ActObjectMemberModel>
	{
		
		public static ActObjectMemberModelHelper OBJ = new ActObjectMemberModelHelper();
		
		public static ActObjectMemberModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActObjectMemberModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("excludeFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetExcludeFlag(value);
					}
					
					
					
					
					
					if ("actRange".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActRange(value);
					}
					
					
					
					
					
					if ("objectRangeModelList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.model.sync.ActObjectRangeModel> value;
						
						value = new List<com.vip.pms.data.model.sync.ActObjectRangeModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.model.sync.ActObjectRangeModel elem0;
								
								elem0 = new com.vip.pms.data.model.sync.ActObjectRangeModel();
								com.vip.pms.data.model.sync.ActObjectRangeModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetObjectRangeModelList(value);
					}
					
					
					
					
					
					if ("actGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActGoodsModel elem2;
								
								elem2 = new com.vip.pms.data.service.PmsActGoodsModel();
								com.vip.pms.data.service.PmsActGoodsModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActGoodsList(value);
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
		
		
		public void Write(ActObjectMemberModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetExcludeFlag() != null) {
				
				oprot.WriteFieldBegin("excludeFlag");
				oprot.WriteBool((bool)structs.GetExcludeFlag());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("excludeFlag can not be null!");
			}
			
			
			if(structs.GetActRange() != null) {
				
				oprot.WriteFieldBegin("actRange");
				oprot.WriteI32((int)structs.GetActRange()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actRange can not be null!");
			}
			
			
			if(structs.GetObjectRangeModelList() != null) {
				
				oprot.WriteFieldBegin("objectRangeModelList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.model.sync.ActObjectRangeModel _item0 in structs.GetObjectRangeModelList()){
					
					
					com.vip.pms.data.model.sync.ActObjectRangeModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("objectRangeModelList can not be null!");
			}
			
			
			if(structs.GetActGoodsList() != null) {
				
				oprot.WriteFieldBegin("actGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActGoodsModel _item0 in structs.GetActGoodsList()){
					
					
					com.vip.pms.data.service.PmsActGoodsModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActObjectMemberModel bean){
			
			
		}
		
	}
	
}