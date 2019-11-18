using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class ShipResponseHelper : TBeanSerializer<ShipResponse>
	{
		
		public static ShipResponseHelper OBJ = new ShipResponseHelper();
		
		public static ShipResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ShipResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("success_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSuccess_num(value);
					}
					
					
					
					
					
					if ("success_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.ShipResult> value;
						
						value = new List<vipapis.jitx.ShipResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.ShipResult elem1;
								
								elem1 = new vipapis.jitx.ShipResult();
								vipapis.jitx.ShipResultHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSuccess_list(value);
					}
					
					
					
					
					
					if ("failed_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.ShipResult> value;
						
						value = new List<vipapis.jitx.ShipResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.ShipResult elem3;
								
								elem3 = new vipapis.jitx.ShipResult();
								vipapis.jitx.ShipResultHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFailed_list(value);
					}
					
					
					
					
					
					if ("failed_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFailed_num(value);
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
		
		
		public void Write(ShipResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSuccess_num() != null) {
				
				oprot.WriteFieldBegin("success_num");
				oprot.WriteI32((int)structs.GetSuccess_num()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccess_list() != null) {
				
				oprot.WriteFieldBegin("success_list");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.ShipResult _item0 in structs.GetSuccess_list()){
					
					
					vipapis.jitx.ShipResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailed_list() != null) {
				
				oprot.WriteFieldBegin("failed_list");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.ShipResult _item0 in structs.GetFailed_list()){
					
					
					vipapis.jitx.ShipResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailed_num() != null) {
				
				oprot.WriteFieldBegin("failed_num");
				oprot.WriteI32((int)structs.GetFailed_num()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ShipResponse bean){
			
			
		}
		
	}
	
}