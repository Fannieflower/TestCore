using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class ConfirmTransferringDeliveryResHelper : TBeanSerializer<ConfirmTransferringDeliveryRes>
	{
		
		public static ConfirmTransferringDeliveryResHelper OBJ = new ConfirmTransferringDeliveryResHelper();
		
		public static ConfirmTransferringDeliveryResHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmTransferringDeliveryRes structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("confirmResults".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.transferring.api.ConfirmResult> value;
						
						value = new List<vipapis.xstore.cc.transferring.api.ConfirmResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.transferring.api.ConfirmResult elem0;
								
								elem0 = new vipapis.xstore.cc.transferring.api.ConfirmResult();
								vipapis.xstore.cc.transferring.api.ConfirmResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetConfirmResults(value);
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
		
		
		public void Write(ConfirmTransferringDeliveryRes structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetConfirmResults() != null) {
				
				oprot.WriteFieldBegin("confirmResults");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.transferring.api.ConfirmResult _item0 in structs.GetConfirmResults()){
					
					
					vipapis.xstore.cc.transferring.api.ConfirmResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmTransferringDeliveryRes bean){
			
			
		}
		
	}
	
}