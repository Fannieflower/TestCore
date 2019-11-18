using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.inventory{
	
	
	
	public class GetCooperationNoListResponseHelper : TBeanSerializer<GetCooperationNoListResponse>
	{
		
		public static GetCooperationNoListResponseHelper OBJ = new GetCooperationNoListResponseHelper();
		
		public static GetCooperationNoListResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetCooperationNoListResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("has_next".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetHas_next(value);
					}
					
					
					
					
					
					if ("cooperation_no_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.inventory.CooperationNo> value;
						
						value = new List<vipapis.inventory.CooperationNo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.inventory.CooperationNo elem0;
								
								elem0 = new vipapis.inventory.CooperationNo();
								vipapis.inventory.CooperationNoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCooperation_no_list(value);
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
		
		
		public void Write(GetCooperationNoListResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHas_next() != null) {
				
				oprot.WriteFieldBegin("has_next");
				oprot.WriteBool((bool)structs.GetHas_next());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCooperation_no_list() != null) {
				
				oprot.WriteFieldBegin("cooperation_no_list");
				
				oprot.WriteListBegin();
				foreach(vipapis.inventory.CooperationNo _item0 in structs.GetCooperation_no_list()){
					
					
					vipapis.inventory.CooperationNoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetCooperationNoListResponse bean){
			
			
		}
		
	}
	
}